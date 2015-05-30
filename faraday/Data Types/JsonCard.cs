using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace faraday.Data_Types
{
    [DataContract]
    public sealed class CardJSON
    {
        [DataMember(Name = "type", IsRequired = false)]
        public string Type { get; set; }

        [DataMember(Name = "title", IsRequired = false)]
        public string Title { get; set; }

        [DataMember(Name = "help", IsRequired = false)]
        public string Help { get; set; }

        [DataMember(Name = "body", IsRequired = false)]
        public string Body { get; set; }

        [DataMember(Name = "id", IsRequired = false)]
        public string ID { get; set; }

        public CardJSON()
        {
        }

        public CardJSON(string json)
        {
            DataContractJsonSerializer parser = new DataContractJsonSerializer(typeof(string));

            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));

            Object tempCard = parser.ReadObject(stream);
            if (tempCard is CardJSON)
            {
                CardJSON card = tempCard as CardJSON;

                Type = card.Type;
                Title = card.Title;
                Help = card.Help;
                Body = card.Body;
                ID = card.ID;
            }
        }
    }
}
