namespace DemoLibrary
{
    class ChildAccessLevel : AccessLevel
    {
        private void Demo()
        {
            PrivateProtectedAccess();
            ProtectedAccess();
            InternalAccess();
            ProtectedInternalAccess();
            PublicAccess();
        }
    }
}
