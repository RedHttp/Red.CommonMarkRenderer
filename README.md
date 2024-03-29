## The RedHttp project is no longer maintained. See [Carter](https://github.com/CarterCommunity/Carter) for a similar low-ceremony experience.

# CommonMark renderer extension for RedHttpServer
### CommonMark renderer is an extension for RedHttpServer, to render CommonMark (and Markdown) using [CommonMark.NET](https://github.com/Knagis/CommonMark.NET)
[![GitHub](https://img.shields.io/github/license/redhttp/red.commonmarkrenderer)](https://github.com/RedHttp/Red.CommonMarkRenderer/blob/master/LICENSE.md)
[![Nuget](https://img.shields.io/nuget/v/red.commonmarkrenderer)](https://www.nuget.org/packages/red.commonmarkrenderer/)
[![Nuget](https://img.shields.io/nuget/dt/red.commonmarkrenderer)](https://www.nuget.org/packages/red.commonmarkrenderer/)
![Dependent repos (via libraries.io)](https://img.shields.io/librariesio/dependent-repos/nuget/red.commonmarkrenderer)

### Usage
After installing and referencing this library, the `Red.Response` has the extension methods 
`RenderFile(filePath, ..)` and `RenderString(commonMarkText, fileName, ..)`

`RenderFile(filePath, ..)` takes the path of a CommonMark or Markdown file, renders it to html and sends it as response.

`RenderString(commonMarkText, fileName, ..)` renders a string containing CommonMark or Markdown text, renders it and sends it as reponse.
The `fileName` parameter is optional and is used to specify a filename attached through a `Content-Disposition`-header.
