Dibware.Helpers
===============

A C# .Net  assembly of helpers for general coding situations

##Classes
* Dibware.Helpers.System.EnumHelper



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
