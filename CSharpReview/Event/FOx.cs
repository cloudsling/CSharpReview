using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.Event
{
    internal sealed class Fox
    {
        public Fox(MailManager manager)
        {
            manager.NewMail += FaxMsg;
        }

        public void FaxMsg(object sender, NewMailEventArgs e)
        {
            // TODO: handle when new mail comes
        }

        public void UnRegister(MailManager manager)
        {
            manager.NewMail -= FaxMsg;
        }
    }
}
