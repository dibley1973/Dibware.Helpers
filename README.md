Dibware.Helpers
===============

A C# .Net  assembly of helpers for general coding situations

##Classes
* Dibware.Helpers.System.EnumHelper
* Dibware.Helpers.Validation.Guard
* Dibware.Helpers.Validation.Ensure
* Dibware.Helpers.Validation.EnsureOfT


### Dibware.Helpers.System.EnumHelper
A helper class for use with bitwise flag enumerations

#### Members
* IEnumerable<T> GetAllSelectedItems<T>(Enum value)
* String GetName<T>(Enum value)

##### IEnumerable<T> GetAllSelectedItems<T>(Enum value)
Gets all combined items from an enum value where the enum is expressed as bitwise flags.

##### String GetName<T>(Enum value)
Retrieves the name of the constant in the specified enumeration that has the specified value.
Basically just a wrapper for the built in .Net Enum.GetName(System.Type enumType, object value) method


### Dibware.Helpers.Validation.Guard
Encapsulates guard clause logic

#### Members
* void ArgumentOutOfRange(Boolean condition, [InvokerParameterName] string argumentName)
* void ArgumentOutOfRange(Boolean condition, [InvokerParameterName] string argumentName, String message)
* void InvalidOperation(Boolean condition, String message)
* void ArgumentIsNotNull(object value, [InvokerParameterName] string argumentName)
* void NotEqualsDefaultOfType<T>(T value, [InvokerParameterName] string argumentName)
* void ArgumentIsNotNullOrEmpty(string value, [InvokerParameterName] string argumentName)
* void ArgumentIsNullOrWhiteSpace(string value, [InvokerParameterName] string argumentName)
* void ArgumentIsAlphaNumeric(string value, [InvokerParameterName] string argumentName)
* void ArgumentConformsToRegex(string value, string regularExpressionPattern, [InvokerParameterName] string argumentName)

#### void ArgumentOutOfRange(Boolean condition, [InvokerParameterName] string argumentName)
Checks if the specified condition is true. If it is a System.ArgumentOutOfRangeException is thrown with the argument name

#### void ArgumentOutOfRange(Boolean condition, [InvokerParameterName] string argumentName, String message)
Checks if the specified condition is true. If it is a System.ArgumentOutOfRangeException is thrown with the argument name and specified message

#### void ArgumentOutOfRange(Boolean condition, [InvokerParameterName] string argumentName, String message)
Checks if the specified condition is true. If it is a System.ArgumentOutOfRangeException is thrown with the argument name and specified message

#### void ArgumentIsNotNull(object value, [InvokerParameterName] string argumentName)
Checks if the specified arguments the is not null. If it is throws a System.ArgumentNullException

#### void NotEqualsDefaultOfType<T>(T value, [InvokerParameterName] string argumentName)
Checks if the specified argument value has the default value for the type. If it has then a System.ArgumentNullException is thrown.

#### void ArgumentIsNotNullOrEmpty(string value, [InvokerParameterName] string argumentName)
Checks if the specified string is not null or empty. If it is throws a System.ArgumentNullException

#### void ArgumentIsNullOrWhiteSpace(string value, [InvokerParameterName] string argumentName)
Checks if the specified string is not null, empty, or white space. If it is throws a System.ArgumentNullException

#### void ArgumentIsAlphaNumeric(string value, [InvokerParameterName] string argumentName)
Checks if the specified string only has alphabetical or numeric charaters. If it does not, then throws a System.ArgumentNullException

#### void ArgumentConformsToRegex(string value, string regularExpressionPattern, [InvokerParameterName] string argumentName)
Checks if the specified string only conforms to the specified regular expression. If it does not, then throws a System.ArgumentNullException



### Dibware.Helpers.Validation.Ensure
Encapsualtes logic to ensures arguments pass specific validation.

#### Members
* string ArgumentIsNotNullOrEmpty(String value, string argumentName)
* static string ArgumentIsNotNullOrWhiteSpace(String value, String argumentName)

#### string ArgumentIsNotNullOrEmpty(String value, string argumentName)
Checks if the specified string is not null or empty. If it is throws a System.ArgumentNullException.

#### static string ArgumentIsNotNullOrWhiteSpace(String value, String argumentName)
Checks if the specified string is not null, empty or whitespace. If it is throws a System.ArgumentNullException.

### Dibware.Helpers.Validation.EnsureOfT
Encapsualtes logic to ensures arguments pass specific validation.

#### Members
* T IsNotNull(T value, String itemName)

#### T IsNotNull(T value, String itemName)
Checks if the specified item is not null. If it is throws a System.NullReferenceException