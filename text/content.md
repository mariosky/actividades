## Constructores 

Cuando creamos un objeto, debemos establecer cual será su estado inicial. Recordemos que
el estado inicial de un objeto está dado por los valores actuales de sus propiedades.

### Sintaxis para crear un constructor ###
Un constructor *el nombre está dado por el de la clase.*

```python
def foo(a, b):
  return a + b

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

```

```csharp 
class Clase 
{
  int campo;
}
```

``` 
class Clase 
{
  int campo;
}
```

