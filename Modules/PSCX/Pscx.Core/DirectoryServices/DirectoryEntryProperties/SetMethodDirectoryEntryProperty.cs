//---------------------------------------------------------------------
// Author: jachymko
//
// Description: Class describing a write-only DirectoryEntry property 
//              calling an entry method.
//
// Creation Date: 20 Feb 2007
//---------------------------------------------------------------------
using System;

namespace Pscx.DirectoryServices
{
    public class SetMethodDirectoryEntryProperty : DirectoryEntryProperty
    {
        private readonly string _methodName;

        public SetMethodDirectoryEntryProperty(string name, string methodName)
            : base(name, DirectoryEntryPropertyAccess.Write)
        {
            _methodName = methodName;
        }

        protected override void OnSetValue(object value)
        {
            try
            {
                Entry.Invoke(_methodName, value);
            }
            catch (System.Reflection.TargetInvocationException exc)
            {
                throw exc.GetBaseException();
            }
        }
    }
}
