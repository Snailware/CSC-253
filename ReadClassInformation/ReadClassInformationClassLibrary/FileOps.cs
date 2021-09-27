using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ReadClassInformationClassLibrary
{
    /// <summary>
    /// class for performing file operations.
    /// </summary>
	public static class FileOps
	{
        /// <summary>
        /// read person obj from json file.
        /// </summary>
        /// <param name="filePath">path to person file.</param>
        /// <param name="person">person object created from file.</param>
        /// <returns>status of file read.</returns>
		public static string ReadPersonFromFile(string filePath, out Person person)
		{
            string status;

            try
            {
                string personJson = File.ReadAllText(filePath);
                // open file, read all json text, then close.

                person = JsonSerializer.Deserialize<Person>(personJson);
                // parse person from json and set to person out param. 

                status = "PERSON LOADED SUCCESSFULLY.";
                // set status for success.
            }
            catch (Exception ex)
            {
                person = null;
                // set person to null;

                status = ex.Message;
                // set status for failure adding excpetion message.
            }

            return status;
            // return load status.
        }
    }
}
