import yaml
import json
import glob
import markdown

activity_types = {'activity': ['content'],
                  'program': ['unit_test', 'initial_code',
                              'instructions', 'reg_exp'],
                  'quiz': ['content']
                  }

markdown_files = ['content', 'instructions']


def to_json(activity_type, path):
    activity = {}
    with open('{path}activity.yml'.format(path=path)) as yaml_file:
        activity = yaml.safe_load(yaml_file)

    for file in activity_types[activity_type]:
        files = glob.glob('{path}{file}*'.format(path=path, file=file))
        print(files)
        for f in files:
            with open(f) as md_file:
                activity_md = md_file.read()
                if file in markdown_files:
                    activity_md = markdown.markdown(activity_md,
                                                    extensions=['fenced_code',
                                                                'tables',
                                                                'footnotes'])
                activity[file] = activity_md

    json_activity = json.dumps(activity)
    return json_activity


if __name__ == "__main__":
    import argparse
    description = "Programa para generar el archivo json de una actividad a partir de archivos de markdown, yaml y html."
    parser = argparse.ArgumentParser(description=description)
    parser.add_argument('activity_type', choices=['activity', 'program', 'quiz'],
                        help="se debe especificar como primer argumento el tipo de actividad, opciones: activity, program, quiz")
    parser.add_argument('path', type=str, help='se debe especificar el directorio donde se encuentran los archivos de la actividad') 
    args = parser.parse_args()

    json_object = to_json(args.activity_type, args.path)
    file_name = args.path[:-1] + '.json'
    with open(file_name, "w") as outfile:
        outfile.write(json_object)
