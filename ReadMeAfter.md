## Other usages

### Abstraction with interfaces
WIP

### Get all assignable instances
*`Injector.GetAssignableInstances`* method will check and return all instances that can be assign to that type. It can be used for getting all injection that implement same interface.

```
IEnumerator<IService> services = _injector.GetAssignableInstances<IService>();
while(services.MoveNext())
{
    services.Current.Initialize();
}
```

### Binding mock objects to isolate and test code 
WIP

### Other strategies to find injecition targets
WIP

## Error handling
When a error occures there are two ways of to handle it.

- If you instantiate injector with *`true`* parameter, injection will throw exceptions with messages that explians the of origin error. This will be the main use case.

- If you instantiate injector with *`false`* parameter, injection will store errors in a list which you can exemine later with *`Injector.ErrorCount`* and *`Injector.GetError()`*. This way of error handling is ment to use in unit tests.

## Restrictions

### No bindings after injection
WIP

### Binding restirctions
WIP







