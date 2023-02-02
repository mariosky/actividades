import yaml
import json
import glob
import markdown

activity_types = {'activity': ['content'],
                  'program': ['unit_test', 'initial_code',
                              'instructions', 'reg_exp']
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
                                                    extensions=['fenced_code'])
                                                                # , 'codehilite'])
                    print(activity_md)
                activity[file] = activity_md

    json_activity = json.dumps(activity)
    return json_activity


if __name__ == "__main__":
    json_object = to_json('activity', 'text//')
    with open("sample.json", "w") as outfile:
        outfile.write(json_object)
