﻿using Aguacongas.TheIdServer.BlazorApp.Models;
using System.Collections.Generic;

namespace Aguacongas.TheIdServer.BlazorApp.Components
{
    public partial class Toaster
    {
        private List<Notification> _notifications = new List<Notification>();

        protected override void OnInitialized()
        {
            _notifier.Show = notification =>
            {
                _notifications.Add(notification);
                StateHasChanged();
            };
        }

        private void OnToastClosed(Notification notification)
        {
            _notifications.Remove(notification);
            StateHasChanged();
        }
    }
}