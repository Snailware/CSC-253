using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WriteClassInformationClassLibrary
{
    /// <summary>
    /// class for perfroming file operations.
    /// </summary>
	public static class FileOps
	{
        /// <summary>
        /// writer person object to json file.
        /// </summary>
        /// <param name="person">person object to be saved.</param>
        /// <param name="filePath">desired path to save file.</param>
        /// <returns></returns>
		public static string WritePersonToFile(Person person, string filePath)
		{
            string status;

            try
            {
                string characterJson = JsonSerializer.Serialize(person);
                // convert person data to json.

                File.WriteAllText(filePath, characterJson);
                // create new file, write json char data then close.

                status = "PERSON SAVED SUCCESSFULLY.";
                // set status for success.
            }
            catch (Exception ex)
            {
                status = ex.Message;
                // set status for failure adding excpetion message.
            }

            return status;
            // return save status. 
        }
    }
}
