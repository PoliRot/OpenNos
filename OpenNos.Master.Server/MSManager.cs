﻿using Hik.Communication.ScsServices.Service;
using OpenNos.Master.Library.Data;
using System.Collections.Generic;
using OpenNos.Core;

namespace OpenNos.Master.Server
{
    internal class MSManager
    {
        #region Members

        private static MSManager _instance;


        #endregion

        #region Instantiation

        public MSManager()
        {
            WorldServers = new List<WorldServer>();
            LoginServers = new List<IScsServiceClient>();
            ConnectedAccounts = new ThreadSafeGenericList<AccountConnection>();
            AuthentificatedClients = new List<long>();
        }

        #endregion

        #region Properties

        public static MSManager Instance => _instance ?? (_instance = new MSManager());

        public List<long> AuthentificatedClients { get; set; }

        //public List<AccountConnection> ConnectedAccounts { get; set; }
        public ThreadSafeGenericList<AccountConnection> ConnectedAccounts { get; set; }

        public List<IScsServiceClient> LoginServers { get; set; }

        public List<WorldServer> WorldServers { get; set; }

        #endregion
    }
}