# Random Playlist Generator
A Windows command-line tool that creates a random M3U playlist given a directory of media files.

When setup as a scheduled task, this can be used for DLNA Servers that don't support random video playlists out of the box.

This is also a workaround for an issue Serviio has with its "Random Music" option and Sony devices, where it will only play one or two songs, then stop. With this tool, you can create your own random music playlist that Serviio will show and works just fine on Sony devices.

<a href="https://github.com/gabeluci/Random-Playlist-Generator/releases/download/1.01/Random.Playlist.exe">Click here to download Random.Playlist.exe</a>

<b>Usage:</b>
```
Random.Playlist.exe [-d folder1 folder2] [-p playlistName] [-r] [-t audio|video]
                    [-m maxLength] [-x types] [-i types] [-h]

  -d    A list of folders to include, separated by spaces.
        If this is not included, the current folder is used.
  -p    The name of the playlist file. If not specified,
        the playlist will be named after the first folder being searched,
        preceded by the word Random. e.g. Random Music.m3u
  -r    Recurse subfolders.
  -t    Specify whether to look for audio or video files. If not specified,
        the first file found will determine if it looks for audio or video
        files. e.g. If it comes across an audio file first, then only audio
        files will be included.
  -m    Limit the playlist to this many files.
  -x    A list of file extensions to exclude, separated by semicolons.
        e.g. -x m4a;wav
  -i    A list of file extensions to include, separated by semicolons.
        All other files will be ignored. e.g. -i mp3;m4a
  -h    Show this help screen
```

.NET Framework v4.0 is required. If you don't already have it, install from here: https://www.microsoft.com/en-ca/download/details.aspx?id=17851

<b>Need Help?</b>

Create an issue here, or ask in the Serviio forums. There is a thread for this: http://forum.serviio.org/viewtopic.php?f=17&t=22186&sid=c504f55c4ef09a6a3f4ca97fa0ec7bff
