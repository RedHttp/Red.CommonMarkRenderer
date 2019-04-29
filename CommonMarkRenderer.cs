using System;
using System.Net;
using System.Threading.Tasks;

namespace Red.CommonMarkRenderer
{
    /// <summary>
    ///     CommonMark Renderer using CommonMark.NET converter
    /// </summary>
    public static class CommonMarkRenderer
    {
        /// <summary>
        ///     Renders a CommonMark file and sends it
        /// </summary>
        /// <param name="response">The instance of the response</param>
        /// <param name="filePath">The path of the CommonMark file to be rendered</param>
        /// <param name="status">The status code for the response</param>
        public static Task<HandlerType> RenderFile(this Response response, string filePath, HttpStatusCode status = HttpStatusCode.OK) => Task.Run(() =>
        {
            using (var reader = new System.IO.StreamReader(filePath))
            using (var writer = new System.IO.StreamWriter(response.AspNetResponse.Body))
            {
                CommonMark.CommonMarkConverter.Convert(reader, writer);
            }
            return HandlerType.Final;
        });

        /// <summary>
        ///     Renders a string containing CommonMark text to HTML and sends it
        /// </summary>
        /// <param name="response">The instance of the response</param>
        /// <param name="commonMarkText">The CommonMark text to be converted to HTML and sent</param>
        /// <param name="fileName">The filename to specify in response header. Optional</param>
        /// <param name="status">The status code for the response</param>
        /// <returns></returns>
        public static Task<HandlerType> RenderString(this Response response, string commonMarkText, string fileName = null, HttpStatusCode status = HttpStatusCode.OK)
        {
            var html = CommonMark.CommonMarkConverter.Convert(commonMarkText);
            return response.SendString(html, "text/html", fileName, status: status);
        }

    }
}
