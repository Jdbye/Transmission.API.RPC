Transmission-RPC-API
===========================

![.NET Core](https://github.com/Beatlegger/Transmission.API.RPC/workflows/.NET%20Core/badge.svg)
![Nuget](https://img.shields.io/nuget/v/Transmission.API.RPC)

[Official Transmission RPC specs](https://github.com/transmission/transmission/blob/master/extras/rpc-spec.txt) 

C# implementation of the Transmission RPC API.
Up to date with Transmission RPC specification as of Transmission 4.1.0 (rpc-version-semver 5.4.0, rpc-version: 18)

| Command              | Not Implemented | Implemented|
| -------------------- |:-:|:-:|
| torrent-start        |   | x |
| torrent-start-now    |   | x |
| torrent-stop         |   | x |
| torrent-verify       |   | x |
| torrent-reannounce   |   | x |
| torrent-set          |   | x |
| torrent-get          |   | x |
| torrent-add          |   | x |
| torrent-remove       |   | x |
| torrent-set-location |   | x |
| torrent-rename-path  |   | x |
| session-set          |   | x |
| session-get          |   | x |
| session-stats        |   | x |
| blocklist-update     |   | x |
| port-test            |   | x |
| session-close        |   | x |
| queue-move-top       |   | x |
| queue-move-up        |   | x |
| queue-move-down      |   | x |
| queue-move-bottom    |   | x |
| free-space           |   | x |
| group-set            |   | x |
| group-get            |   | x |


How to use
-------------

Install Nuget Package: `PM> Install-Package Transmission.API.RPC`

```C#
using Transmission.API.RPC.Entity;

// URL might look like "schema://host:port/transmission/rpc" for example "https://website.com:9091/transmission/rpc"
var client = new Client("URL", "PARAM_SESSION_ID", "PARAM_LOGIN", "PARAM_PASS");

var sessionInfo = client.GetSessionInformation();
var allTorrents = client.TorrentGet(TorrentFields.ALL_FIELDS);
//<...>
```
