using System;
using System.Collections.Generic;
using System.Text;

namespace integratieDemoConsole
{
    class AlertRepository
    {
        private List<Alert> alertList;

        public AlertRepository()
        {
            alertList = new List<Alert>();
        }
        public AlertRepository(List<Alert> alertList)
        {
            alertList = new List<Alert>();
            this.alertList = alertList;
        }

        public void AddAlert(Alert alert)
        {
            alertList.Add(alert);
        }

        public void checkAlerts(Item[] items, User[] users)
        {
            alertList.ForEach(Alert => Alert.checkAlert(items, users));
        }

    }
}
