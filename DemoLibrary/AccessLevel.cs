namespace DemoLibrary
{
    public class AccessLevel
    {
        // I want to ensure this is available only within this class
        private void PrivateAccess()
        {

        }

        // I want to ensure this is available to anyone who is inherited from this class. But don't make it visible to others
        protected void ProtectedAccess()
        {

        }

        // I want to ensure this is only available to inherited classes which are within this class library
        private protected void PrivateProtectedAccess()
        {

        }

        // I want to ensure this is available to the entire class library but for no one outside this class library
        internal void InternalAccess()
        {

        }

        // I want to ensure this is available to anyone who inherited from this class and to everyone within the class library
        protected internal void ProtectedInternalAccess()
        {

        }

        // I want to ensure this is available to everyone
        public void PublicAccess()
        {

        }
    }
}