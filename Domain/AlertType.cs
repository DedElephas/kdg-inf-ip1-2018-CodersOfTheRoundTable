using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public enum AlertType: byte
    {
        webNotificatie,
        email,
        androidNotificatie
    }
}
