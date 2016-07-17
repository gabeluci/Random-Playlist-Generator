# Random Playlist Generator
A Windows command-line tool that creates a random M3U playlist given a directory of media files.

When setup as a scheduled task, this can be used for DLNA Servers that don't support random video playlists out of the box.

This is also a workaround for an issue Serviio has with its "Random Music" option and Sony devices, where it will only play one or two songs, then stop. With this tool, you can create your own random music playlist that Serviio will show and works just fine on Sony devices.

Usage:
"Random.Playlist.exe" [folder with files] [playlist filename]

If the folder name is omitted, the current folder is used. If the playlist filename is omitted, the filename will be called "Random [directory name]".

.NET Framework v4.0 is required. If you don't already have it, install from here: https://www.microsoft.com/en-ca/download/details.aspx?id=17851
