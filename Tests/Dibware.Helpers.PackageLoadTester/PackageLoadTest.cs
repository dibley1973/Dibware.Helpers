
using Dibware.Helpers.Validation;

namespace Dibware.Helpers.PackageLoadTester
{
    public class PackageLoadTest
    {
        public void GuardTest(int param1, string param2)
        {
            Guard.ArgumentOutOfRange(param1 <= 0, "param1");
            Guard.ArgumentIsNotNullOrEmpty(param2, "param2");

            var value2 = Ensure.ArgumentIsNotNullOrEmpty(param2, "param2");

        }
    }
}
