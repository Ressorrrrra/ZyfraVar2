﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyfraVar2.Repository;
using ZyfraVar2.Services.Interfaces;
using ZyfraVar2.Services;
using ZyfraVar2.Repository.Interfaces;

namespace ZyfraVar2.Tests
{
    public class SessionServiceTest
    {
        ISessionService sessionService;
        string sessionId;


        [SetUp]
        public void Setup()
        {
            string filePath = "Test.csv";
            TestFile.CreateFile(filePath);
            SessionRepository sessionRepository = new SessionRepository();
            sessionService = new SessionService(sessionRepository);
        }

        [Test]
        public void CreateSession()
        {
            sessionId = sessionService.CreateSession("user0");
            if (sessionId.Length == 0) Assert.Fail();

            Assert.Pass();

        }

        [Test]
        public void DeleteSession()
        {
            sessionId = sessionService.CreateSession("user0");

            if (!sessionService.DeleteSession(sessionId)) Assert.Fail();

            if (sessionService.DeleteSession(sessionId)) Assert.Fail();

            if (sessionService.DeleteSession("")) Assert.Fail();

            Assert.Pass();
        }

        [Test]
        public void CheckSession()
        {

            string sessionId = sessionService.CreateSession("login");

            if (!sessionService.CheckSession(sessionId)) Assert.Fail();

            if (sessionService.CheckSession("ww")) Assert.Fail();

            Assert.Pass();

        }

    }
}
