using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.Event
{
    public class NewMailEventArgs : EventArgs
    {
        private readonly string _from, _to, _subject;

        public NewMailEventArgs(string from, string to, string subject)
        {
            _from = from;
            _to = to;
            _subject = subject;
        }

        public string From => _from;

        public string To => _to;

        public string Subject => _subject;
    }
}
