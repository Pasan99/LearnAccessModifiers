namespace DemoLibrary
{
    public class InternalClass
    {
        private void MakeDemoCalls()
        {
            AccessLevel demo = new AccessLevel();
            demo.InternalAccess();
            demo.ProtectedInternalAccess();
            demo.PublicAccess();
        }
    }
}
