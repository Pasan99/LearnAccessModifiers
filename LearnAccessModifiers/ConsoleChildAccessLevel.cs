using DemoLibrary;

namespace LearnAccessModifiers
{
    class ConsoleChildAccessLevel : AccessLevel
    {
        private void Demo()
        {
            ProtectedInternalAccess();
            ProtectedAccess();
            PublicAccess();
        }
    }
}
