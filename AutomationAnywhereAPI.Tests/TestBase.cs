﻿using AutomationAnywhereAPI.Models;

namespace AutomationAnywhereAPI.Tests
{
    public class TestBase
    {
        protected readonly Connection Connection;
        protected TestBase()
        {
            Connection = new Connection()
            {
                Credentials = new Credentials()
                {
                    Username = "",
                    Password = ""
                },
                Url = "controlroomurl",
                User = null
            };
        }
    }
}
