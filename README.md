#### Adapter pattern in C#. Structural

The Adapter design pattern allows incompatible interfaces to work together. It acts as a bridge between two incompatible interfaces.

This pattern can be used in various scenarios, such as integrating legacy code or third-party libraries with your application's code. Below is a real-world example of using the Adapter pattern in a .NET Core 6 application.

##### Scenario:

An eCommerce application has an interface IPaymentGateway for processing payments, but we need to integrate it with a third-party payment gateway which has a different interface.
