# warp
Warp is a tool I wrote a while ago that is essentially a convenient way of producing Youtube gaming series from huge FRAPS recording files. It allows you to specify an introduction clip, a closer clip, and then a folder containing all of the FRAPS clips that you'd like the intro and closer appended to, and Warp will automatically generate high quality, low file-size clips. It also supports presets, allowing you to have defaults for multiple Youtube series (IE. different intro/closer and quality settings). It also supports queuing up jobs, so you may record as many series as you like, and then add them to the render queue as you finish them, and Warp will do the rest.

It was developed in a time where finding a decent video encoding frontend that used all of the available CPU power available to the software was very difficult. Today, with GPU accelerated encoding as well as huge updates to popular video editors limit the usefulness of this tool.

## Input videos
The videos must be of the same file type, resolution, frame rate, etc. It is best if they were created using the same tool. FRAPS clips will always work. 

## Output videos
The output will be x264 encoded video with either the original audio track or a compressed AAC stream. Track separation is left alone, and will be the same as the input clip.

## Other notes
To build the software, simply download this repository, open the SLN file in Visual Studio Express (https://www.visualstudio.com/vs/visual-studio-express/) and then hit build!

## Download
I have provided a precompiled 32 bit executable below, which also includes a tested but old version of the FFMPEG executable. Please feel free to replace this executable with one that is more up to date, but no guarantees it will still function perfectly if you do.
###Binary/precompiled
Extract this wherever you want and run Warp.exe
[Download](http://www.kn100.me/warp/Warp%20release.zip)

### Source code
Available here, feel free to clone, play about, submit patches etc, no problem. This is code that was written almost 5 years ago, and looking back I was a less skilled developer back then than I consider myself now, so please excuse weirdness/bugs in the code!


