﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transsmission.API.RPC;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Transsmission.API.RPC.Entity;

namespace Transmission.API.RPC.Test
{
    [TestClass]
    public class MainTest
    {
        const string SESSION_ID = "eyCd0F1Yxc1ljG4GbROe3542HH6PneD3NjcqmXtnKT6E5Y6b";
        const string HOST = "http://192.168.1.50:9091/transmission/rpc";

        public Client client = new Client();

        [TestInitialize]
        public void Initialize()
        {
            client.Host = HOST;
            client.SessionID = SESSION_ID;
        }

        [TestMethod]
        public void GetSession()
        {
            var sessionInfo = client.GetSession();
        }

        [TestMethod]
        public void GetActiveTorrents()
        {         
            var activeTorrents = client.GetActiveTorrents(client.AllTorrentsFields);
        }

        [TestMethod]
        public void GetAllTorrents()
        {
            var allTorrents = client.GetAllTorrents(client.AllTorrentsFields);
        }

        [TestMethod]
        public void CheckPort()
        {
            client.CheckPort();
        }

        [TestMethod]
        public void AddTorrent()
        {
            var filePath = "D:\\test.torrent";
            var fstream = File.Open(filePath, FileMode.Open);
            var base64 = ConvertToBase64(fstream);
            TransmissionNewTorrent newTorrent = new TransmissionNewTorrent
            {
                Metainfo = base64,
                Paused = false,
                //TODO: Add and check other arguments
                //<...>
            };

            var result = client.AddTorrent(newTorrent);
        }

        [TestMethod]
        public void StartTorrent()
        {
            client.StartTorrents(new int[] { 41 });
        }

        [TestMethod]
        public void StopTorrent()
        {
            client.StopTorrents(new int[] { 41 });
        }

        [TestMethod]
        public void StartNow()
        {
            client.StartNowTorrents(new int[] { 41 });
        }

        [TestMethod]
        public void ReannounceTorrents()
        {
            client.ReannounceTorrents(new int[] { 41 });
        }

        [TestMethod]
        public void VerifyTorrents()
        {
            client.VerifyTorrents(new int[] { 41 });
        }

        [TestMethod]
        public void RemoveTorrent()
        {
            var ids = new int[]{40};

            client.RemoveTorrents(ids);
        }

        [TestMethod]
        public void TorrentsQueueMoveTop()
        {
            client.TorrentsQueueMoveTop(new int[] { 41 });
        }

        [TestMethod]
        public void TorrentsQueueMoveUp()
        {
            client.TorrentsQueueMoveUp(new int[] { 41 });
        }

        [TestMethod]
        public void TorrentsQueueMoveDown()
        {
            client.TorrentsQueueMoveDown(new int[] { 41 });
        }

        [TestMethod]
        public void TorrentsQueueMoveBottom()
        {
            client.TorrentsQueueMoveBottom(new int[] { 41 });
        }

        [TestMethod]
        public void FreeSpace()
        {
            var result = client.FreeSpace("./");
        }

        [TestMethod]
        public void SessionStat()
        {
            var result = client.GetSessionStat();
        }


        public string ConvertToBase64(Stream stream)
        {
            Byte[] inArray = new Byte[(int)stream.Length];
            stream.Read(inArray, 0, (int)stream.Length);
            return Convert.ToBase64String(inArray, 0, inArray.Length);
        }
    }
}