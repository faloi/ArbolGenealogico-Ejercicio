using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbolGenealogico
{
    public class MemberNotFound : Exception
    {
        private object _subject;

        public MemberNotFound(object aSubject)
        {
            _subject = aSubject;
        }

        public Object subject()
        {
            return _subject;
        }
    }
}
