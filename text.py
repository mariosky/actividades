import yaml
import json
import glob

activity_types = {'activity': ['activity.md'],
                  'program': ['unit_test', 'initial_code',
                              'instructions', 'reg_exp']
                  }


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
                activity[file] = activity_md

    json_activity = json.dumps(activity)
    return json_activity


if __name__ == "__main__":
    print(to_json('program', 'program//'))
