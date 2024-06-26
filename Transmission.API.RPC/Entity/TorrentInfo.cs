﻿#nullable enable
using JDRemote.Backends.Transmission;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transmission.API.RPC.Entity
{
    /// <summary>
    /// Torrent information
    /// </summary>
    public class TorrentInfo
    {
        /// <summary>
        /// The torrent's unique Id.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Activity date
        /// </summary>
        [JsonProperty("activityDate")]
        public long? ActivityDate { get; set; }

        /// <summary>
        /// Added date
        /// </summary>
        [JsonProperty("addedDate")]
        public long? AddedDate { get; set; }

        /// <summary>
        /// Availability
        /// </summary>
        [JsonProperty("availability")]
        [JsonConverter(typeof(IntOrArrayConverter))] // Without this converter, Transmission < 4.0.0 leads to an error.
        public long[]? Availability { get; set; }

        /// <summary>
        /// Torrents bandwidth priority
        /// </summary>
        [JsonProperty("bandwidthPriority")]
        public long? BandwidthPriority { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Corrupt ever
        /// </summary>
        [JsonProperty("corruptEver")]
        public long? CorruptEver { get; set; }

        /// <summary>
        /// Creator
        /// </summary>
        [JsonProperty("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        [JsonProperty("dateCreated")]
        public long? DateCreated { get; set; }

        /// <summary>
        /// Desired available
        /// </summary>
        [JsonProperty("desiredAvailable")]
        public long? DesiredAvailable { get; set; }

        /// <summary>
        /// Done date
        /// </summary>
        [JsonProperty("doneDate")]
        public long? DoneDate { get; set; }

        /// <summary>
        /// Download directory
        /// </summary>
        [JsonProperty("downloadDir")]
        public string? DownloadDir { get; set; }

        /// <summary>
        /// Downloaded ever
        /// </summary>
        [JsonProperty("downloadedEver")]
        public long? DownloadedEver { get; set; }

        /// <summary>
        /// Download limit
        /// </summary>
        [JsonProperty("downloadLimit")]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// Download limited
        /// </summary>
        [JsonProperty("downloadLimited")]
        public bool? DownloadLimited { get; set; }

        /// <summary>
        /// Edit date
        /// </summary>
        [JsonProperty("editDate")]
        public long? EditDate { get; set; }

        /// <summary>
        /// Error
        /// </summary>
        [JsonProperty("error")]
        public long? Error { get; set; }

        /// <summary>
        /// Error string
        /// </summary>
        [JsonProperty("errorString")]
        public string? ErrorString { get; set; }

        /// <summary>
        /// ETA
        /// </summary>
        [JsonProperty("eta")]
        public long? Eta { get; set; }

        /// <summary>
        /// ETA idle
        /// </summary>
        [JsonProperty("etaIdle")]
        public long? EtaIdle { get; set; }

        /// <summary>
        /// File count
        /// </summary>
        [JsonProperty("file-count")]
        public long? FileCount { get; set; }

        /// <summary>
        /// Files
        /// </summary>
        [JsonProperty("files")]
        public TransmissionTorrentFiles[]? Files { get; set; }

        /// <summary>
        /// File stats
        /// </summary>
        [JsonProperty("fileStats")]
        public TransmissionTorrentFileStats[]? FileStats { get; set; }

        /// <summary>
        /// Group
        /// </summary>
        [JsonProperty("group")]
        public string? Group { get; set; }

        /// <summary>
        /// Hash string
        /// </summary>
        [JsonProperty("hashString")]
        public string? HashString { get; set; }

        /// <summary>
        /// Have unchecked
        /// </summary>
        [JsonProperty("haveUnchecked")]
        public long? HaveUnchecked { get; set; }

        /// <summary>
        /// Have valid
        /// </summary>
        [JsonProperty("haveValid")]
        public long? HaveValid { get; set; }

        /// <summary>
        /// Honors session limits
        /// </summary>
        [JsonProperty("honorsSessionLimits")]
        public bool? HonorsSessionLimits { get; set; }

        /// <summary>
        /// Is finished
        /// </summary>
        [JsonProperty("isFinished")]
        public bool? IsFinished { get; set; }

        /// <summary>
        /// Is private
        /// </summary>
        [JsonProperty("isPrivate")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Is stalled
        /// </summary>
        [JsonProperty("isStalled")]
        public bool? IsStalled { get; set; }

        /// <summary>
        /// Labels
        /// </summary>
        [JsonProperty("labels")]
        public string[]? Labels { get; set; }

        /// <summary>
        /// Left until done
        /// </summary>
        [JsonProperty("leftUntilDone")]
        public long? LeftUntilDone { get; set; }

        /// <summary>
        /// Magnet link
        /// </summary>
        [JsonProperty("magnetLink")]
        public string? MagnetLink { get; set; }

        /// <summary>
        /// Manual announce time
        /// </summary>
        [JsonProperty("manualAnnounceTime")]
        public long? ManualAnnounceTime { get; set; }

        /// <summary>
        /// Max connected peers
        /// </summary>
        [JsonProperty("maxConnectedPeers")]
        public long? MaxConnectedPeers { get; set; }

        /// <summary>
        /// Metadata percent complete
        /// </summary>
        [JsonProperty("metadataPercentComplete")]
        public double? MetadataPercentComplete { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Peer limit
        /// </summary>
        [JsonProperty("peer-limit")]
        public long? PeerLimit { get; set; }

        /// <summary>
        /// Peers
        /// </summary>
        [JsonProperty("peers")]
        public TransmissionTorrentPeers[]? Peers { get; set; }

        /// <summary>
        /// Peers connected
        /// </summary>
        [JsonProperty("peersConnected")]
        public long? PeersConnected { get; set; }

        /// <summary>
        /// Peers from
        /// </summary>
        [JsonProperty("peersFrom")]
        public TransmissionTorrentPeersFrom? PeersFrom { get; set; }

        /// <summary>
        /// Peers getting from us
        /// </summary>
        [JsonProperty("peersGettingFromUs")]
        public long? PeersGettingFromUs { get; set; }

        /// <summary>
        /// Peers sending to us
        /// </summary>
        [JsonProperty("peersSendingToUs")]
        public long? PeersSendingToUs { get; set; }

        /// <summary>
        /// Percent complete
        /// </summary>
        [JsonProperty("percentComplete")]
        public double? PercentComplete { get; set; }

        /// <summary>
        /// Percent done
        /// </summary>
        [JsonProperty("percentDone")]
        public double? PercentDone { get; set; }

        /// <summary>
        /// Pieces
        /// </summary>
        [JsonProperty("pieces")]
        public string? Pieces { get; set; }

        /// <summary>
        /// Piece count
        /// </summary>
        [JsonProperty("pieceCount")]
        public long? PieceCount { get; set; }

        /// <summary>
        /// Piece size
        /// </summary>
        [JsonProperty("pieceSize")]
        public long? PieceSize { get; set; }

        /// <summary>
        /// Priorities
        /// </summary>
        [JsonProperty("priorities")]
        public long[]? Priorities { get; set; }

        /// <summary>
        /// Primary mime type
        /// </summary>
        [JsonProperty("primary-mime-type")]
        public string? PrimaryMimeType { get; set; }

        /// <summary>
        /// Queue position
        /// </summary>
        [JsonProperty("queuePosition")]
        public long? QueuePosition { get; set; }

        /// <summary>
        /// Rate download
        /// </summary>
        [JsonProperty("rateDownload")]
        public long? RateDownload { get; set; }

        /// <summary>
        /// Rate upload
        /// </summary>
        [JsonProperty("rateUpload")]
        public long? RateUpload { get; set; }

        /// <summary>
        /// Recheck progress
        /// </summary>
        [JsonProperty("recheckProgress")]
        public double? RecheckProgress { get; set; }

        /// <summary>
        /// Seconds downloading
        /// </summary>
        [JsonProperty("secondsDownloading")]
        public long? SecondsDownloading { get; set; }

        /// <summary>
        /// Seconds seeding
        /// </summary>
        [JsonProperty("secondsSeeding")]
        public long? SecondsSeeding { get; set; }

        /// <summary>
        /// Seed idle limit
        /// </summary>
        [JsonProperty("seedIdleLimit")]
        public long? SeedIdleLimit { get; set; }

        /// <summary>
        /// Seed idle mode
        /// </summary>
        [JsonProperty("seedIdleMode")]
        public long? SeedIdleMode { get; set; }

        /// <summary>
        /// Seed ratio limit
        /// </summary>
        [JsonProperty("seedRatioLimit")]
        public double? SeedRatioLimit { get; set; }

        /// <summary>
        /// Seed ratio mode
        /// </summary>
        [JsonProperty("seedRatioMode")]
        public long? SeedRatioMode { get; set; }

        /// <summary>
        /// Sequential Download
        /// </summary>
        [JsonProperty("sequentialDownload")]
        public bool? SequentialDownload { get; set; }

        /// <summary>
        /// Size when done
        /// </summary>
        [JsonProperty("sizeWhenDone")]
        public long? SizeWhenDone { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [JsonProperty("startDate")]
        public long? StartDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public long? Status { get; set; }

        /// <summary>
        /// Trackers
        /// </summary>
        [JsonProperty("trackers")]
        public TransmissionTorrentTrackers[]? Trackers { get; set; }

        /// <summary>
        /// Tracker list:
        /// A string of announce URLs, one per line, with a blank
        /// line between tiers
        /// </summary>
        [JsonProperty("trackerList")]
        public string? TrackerList { get; set; }

        /// <summary>
        /// Tracker stats
        /// </summary>
        [JsonProperty("trackerStats")]
        public TransmissionTorrentTrackerStats[]? TrackerStats { get; set; }

        /// <summary>
        /// Total size
        /// </summary>
        [JsonProperty("totalSize")]
        public long? TotalSize { get; set; }

        /// <summary>
        /// Torrent file
        /// </summary>
        [JsonProperty("torrentFile")]
        public string? TorrentFile { get; set; }

        /// <summary>
        /// Uploaded ever
        /// </summary>
        [JsonProperty("uploadedEver")]
        public long? UploadedEver { get; set; }

        /// <summary>
        /// Upload limit
        /// </summary>
        [JsonProperty("uploadLimit")]
        public long? UploadLimit { get; set; }

        /// <summary>
        /// Upload limited
        /// </summary>
        [JsonProperty("uploadLimited")]
        public bool? UploadLimited { get; set; }

        /// <summary>
        /// Upload ratio
        /// </summary>
        [JsonProperty("uploadRatio")]
        public double? uploadRatio { get; set; }

        /// <summary>
        /// Wanted
        /// </summary>
        [JsonProperty("wanted")]
        public bool[]? Wanted { get; set; }

        /// <summary>
        /// Web seeds
        /// </summary>
        [JsonProperty("webseeds")]
        public string[]? Webseeds { get; set; }

        /// <summary>
        /// Web seeds sending to us
        /// </summary>
        [JsonProperty("webseedsSendingToUs")]
        public long? WebseedsSendingToUs { get; set; }
    }

    /// <summary>
    /// Torrent files
    /// </summary>
    public class TransmissionTorrentFiles
    {
        /// <summary>
        /// Bytes completed
        /// </summary>
        [JsonProperty("bytesCompleted")]
        public long? BytesCompleted{ get; set; }

        /// <summary>
        /// Length
        /// </summary>
        [JsonProperty("length")]
        public long? Length{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string? Name{ get; set; }

        /// <summary>
        /// First piece index of file
        /// </summary>
        [JsonProperty("beginPiece")]
        public long? BeginPiece { get; set; }

        /// <summary>
        /// Last piece index of file
        /// </summary>
        [JsonProperty("endPiece")]
        public long? EndPiece { get; set; }
    }

    /// <summary>
    /// Torrent file stats
    /// </summary>
    public class TransmissionTorrentFileStats
    {
        /// <summary>
        /// Bytes completed
        /// </summary>
        [JsonProperty("bytesCompleted")]
        public long? BytesCompleted{ get; set; }

        /// <summary>
        /// Wanted
        /// </summary>
        [JsonProperty("wanted")]
        public bool? Wanted{ get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        [JsonProperty("priority")]
        public long? Priority{ get; set; }
    }

    /// <summary>
    /// Torrent peers
    /// </summary>
    public class TransmissionTorrentPeers
    {
        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public string? Address{ get; set; }

        /// <summary>
        /// Client name
        /// </summary>
        [JsonProperty("clientName")]
        public string? ClientName{ get; set; }

        /// <summary>
        /// Client is choked
        /// </summary>
        [JsonProperty("clientIsChoked")]
        public bool? ClientIsChoked{ get; set; }

        /// <summary>
        /// Client is Interested
        /// </summary>
        [JsonProperty("clientIsInterested")]
        public bool? ClientIsInterested{ get; set; }

        /// <summary>
        /// Flag string
        /// </summary>
        [JsonProperty("flagStr")]
        public string? FlagStr{ get; set; }

        /// <summary>
        /// Is downloading from
        /// </summary>
        [JsonProperty("isDownloadingFrom")]
        public bool? IsDownloadingFrom{ get; set; }

        /// <summary>
        /// Is encrypted
        /// </summary>
        [JsonProperty("isEncrypted")]
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Is incoming
        /// </summary>
        [JsonProperty("isIncoming")]
        public bool? IsIncoming { get; set; }

        /// <summary>
        /// Is uploading to
        /// </summary>
        [JsonProperty("isUploadingTo")]
        public bool? IsUploadingTo{ get; set; }

        /// <summary>
        /// Is UTP
        /// </summary>
        [JsonProperty("isUTP")]
        public bool? IsUtp{ get; set; }

        /// <summary>
        /// Peer is choked
        /// </summary>
        [JsonProperty("peerIsChoked")]
        public bool? PeerIsChoked{ get; set; }

        /// <summary>
        /// Peer is Interested
        /// </summary>
        [JsonProperty("peerIsInterested")]
        public bool? PeerIsInterested{ get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Progress
        /// </summary>
        [JsonProperty("progress")]
        public double? Progress{ get; set; }

        /// <summary>
        /// Rate to client
        /// </summary>
        [JsonProperty("rateToClient")]
        public long? RateToClient{ get; set; }

        /// <summary>
        /// Rate to peer
        /// </summary>
        [JsonProperty("rateToPeer")]
        public long? RateToPeer{ get; set; }
    }

    /// <summary>
    /// Torrent peers from
    /// </summary>
    public class TransmissionTorrentPeersFrom
    {
        /// <summary>
        /// From cache
        /// </summary>
        [JsonProperty("fromCache")]
        public long? FromCache { get; set; }

        /// <summary>
        /// From DHT
        /// </summary>
        [JsonProperty("fromDht")]
        public long? FromDht { get; set; }

        /// <summary>
        /// From incoming
        /// </summary>
        [JsonProperty("fromIncoming")]
        public long? FromIncoming{ get; set; }

        /// <summary>
        /// From LPD
        /// </summary>
        [JsonProperty("fromLpd")]
        public long? FromLpd{ get; set; }

        /// <summary>
        /// From LTEP
        /// </summary>
        [JsonProperty("fromLtep")]
        public long? FromLtep{ get; set; }

        /// <summary>
        /// From PEX
        /// </summary>
        [JsonProperty("fromPex")]
        public long? FromPex{ get; set; }

        /// <summary>
        /// From tracker
        /// </summary>
        [JsonProperty("fromTracker")]
        public long? FromTracker{ get; set; }
    }

    /// <summary>
    /// Torrent trackers
    /// </summary>
    public class TransmissionTorrentTrackers
    {
        /// <summary>
        /// Announce
        /// </summary>
        [JsonProperty("announce")]
        public string? Announce{ get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public long Id{ get; set; }

        /// <summary>
        /// Scrape
        /// </summary>
        [JsonProperty("scrape")]
        public string? Scrape{ get; set; }

        /// <summary>
        /// Site name
        /// </summary>
        [JsonProperty("sitename")]
        public string? SiteName { get; set; }

        /// <summary>
        /// Tier
        /// </summary>
        [JsonProperty("tier")]
        public long? Tier{ get; set; }
    }

    /// <summary>
    /// Torrent tracker stats
    /// </summary>
    public class TransmissionTorrentTrackerStats
    {
        /// <summary>
        /// Announce
        /// </summary>
        [JsonProperty("announce")]
        public string? Announce{ get; set; }

        /// <summary>
        /// Announce state
        /// </summary>
        [JsonProperty("announceState")]
        public long? AnnounceState{ get; set; }

        /// <summary>
        /// Download count
        /// </summary>
        [JsonProperty("downloadCount")]
        public long? DownloadCount{ get; set; }

        /// <summary>
        /// Has announced
        /// </summary>
        [JsonProperty("hasAnnounced")]
        public bool? HasAnnounced{ get; set; }

        /// <summary>
        /// Has scraped
        /// </summary>
        [JsonProperty("hasScraped")]
        public bool? HasScraped{ get; set; }

        /// <summary>
        /// Host
        /// </summary>
        [JsonProperty("host")]
        public string? Host{ get; set; }

        /// <summary>
        /// Is backup
        /// </summary>
        [JsonProperty("isBackup")]
        public bool? IsBackup{ get; set; }

        /// <summary>
        /// Last announce peer count
        /// </summary>
        [JsonProperty("lastAnnouncePeerCount")]
        public long? LastAnnouncePeerCount{ get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Last announce result 
        /// </summary>
        [JsonProperty("lastAnnounceResult")]
        public string? LastAnnounceResult{ get; set; }

        /// <summary>
        /// Last announce succeeded
        /// </summary>
        [JsonProperty("lastAnnounceSucceeded")]
        public bool? LastAnnounceSucceeded{ get; set; }

        /// <summary>
        /// Last announce start time
        /// </summary>
        [JsonProperty("lastAnnounceStartTime")]
        public long? LastAnnounceStartTime{ get; set; }

        /// <summary>
        /// Last scrape result
        /// </summary>
        [JsonProperty("lastScrapeResult")]
        public string? LastScrapeResult{ get; set; }

        /// <summary>
        /// Last announce timed out
        /// </summary>
        [JsonProperty("lastAnnounceTimedOut")]
        public bool? LastAnnounceTimedOut{ get; set; }

        /// <summary>
        /// Last announce time
        /// </summary>
        [JsonProperty("lastAnnounceTime")]
        public long? LastAnnounceTime{ get; set; }

        /// <summary>
        /// Last scrape scceeded
        /// </summary>
        [JsonProperty("lastScrapeSucceeded")]
        public bool? LastScrapeSucceeded{ get; set; }

        /// <summary>
        /// Last scrape start time
        /// </summary>
        [JsonProperty("lastScrapeStartTime")]
        public long? LastScrapeStartTime{ get; set; }

        /// <summary>
        /// Last scrape timed out
        /// </summary>
        [JsonProperty("lastScrapeTimedOut")]
        public bool? LastScrapeTimedOut{ get; set; }

        /// <summary>
        /// Last scrape time
        /// </summary>
        [JsonProperty("lastScrapeTime")]
        public long? LastScrapeTime{ get; set; }

        /// <summary>
        /// Scrape
        /// </summary>
        [JsonProperty("scrape")]
        public string? Scrape{ get; set; }

        /// <summary>
        /// Tier
        /// </summary>
        [JsonProperty("tier")]
        public long? Tier{ get; set; }

        /// <summary>
        /// Leecher count
        /// </summary>
        [JsonProperty("leecherCount")]
        public long? LeecherCount{ get; set; }

        /// <summary>
        /// Next announce time
        /// </summary>
        [JsonProperty("nextAnnounceTime")]
        public long? NextAnnounceTime{ get; set; }

        /// <summary>
        /// Next scrape time
        /// </summary>
        [JsonProperty("nextScrapeTime")]
        public long? NextScrapeTime{ get; set; }

        /// <summary>
        /// Scrape state
        /// </summary>
        [JsonProperty("scrapeState")]
        public long? ScrapeState{ get; set; }

        /// <summary>
        /// Seeder count
        /// </summary>
        [JsonProperty("seederCount")]
        public long? SeederCount{ get; set; }

        /// <summary>
        /// Site name
        /// </summary>
        [JsonProperty("sitename")]
        public string? SiteName { get; set; }
    }

    /// <summary>
    /// Contains arrays of torrents, and removed torrents in an integer array
    /// </summary>
    public class TransmissionTorrents
    {
        /// <summary>
        /// Array of torrents
        /// </summary>
        [JsonProperty("torrents")]
        public TorrentInfo[]? Torrents{ get; set; }

        /// <summary>
        /// Array of torrent-id numbers of recently-removed torrents
        /// </summary>
        [JsonProperty("removed")]
        public long[]? Removed{ get; set; }
    }
}
