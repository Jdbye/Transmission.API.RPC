﻿#nullable enable
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transmission.API.RPC.Entity
{
	/// <summary>
	/// Information of added torrent
	/// </summary>
	public class NewTorrentInfo
	{
		/// <summary>
		/// Torrent ID
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// Torrent name
		/// </summary>
		[JsonProperty("name")]
		public string? Name { get; set; }

		/// <summary>
		/// Torrent Hash
		/// </summary>
		[JsonProperty("hashString")]
		public string? HashString { get; set; }

        /// <summary>
        /// Whether the torrent is a duplicate of an existing torrent (add failed)
        /// </summary>
        public bool? Duplicate { get; set; }

	}
}
