using System;
using System.Collections.Generic;

namespace OpenFromURL
{
    public class WTCSSchool
    {
        public string SchoolName { get; set; }
        public string url { get; set; }
        public string ImageURL { get; set; }

        public static List<WTCSSchool> WTCSSChools
        {
            get => new List<WTCSSchool>()
                {
                    new WTCSSchool() {SchoolName="Blackhawk", url="https://www.blackhawk.edu/", ImageURL="http://www.blackhawk.edu/"},
                    new WTCSSchool() {SchoolName="Chippewa Valley", url="https://www.cvtc.edu/Pages/default.aspx", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=a20b6bd4-dff7-437b-bf5a-8885b48e05b6&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Fox Valley", url="https://www.fvtc.edu/public/", ImageURL="https://www.fvtc.edu/portals/_default/skins/fvtcresponsive/images/logo.png"},
                    new WTCSSchool() {SchoolName="Gateway", url="http://www.gtc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=15d79492-e366-4282-ae7f-5ba597cf408e&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Lakeshore", url="https://www.gotoltc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=6075c151-6d0a-49f5-9699-8bf12e5527d3&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Madison College", url="https://madisoncollege.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=bcdad865-bc67-4f22-a623-4beecc252c4e&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Mid-State", url="http://www.mstc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=0edf6c34-f374-43c8-a8bc-84e31c1981a8&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Milwaukee Area College", url="http://www.matc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=621482db-3011-42c4-9921-3a62730ab288&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Moraine Park College", url="http://www.morainepark.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=b4148f11-6f08-446b-93a4-98366e661f7f&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Nicolet College", url="http://www.nicoletcollege.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=a3fb0492-ad1d-4da2-9419-e3c378bfe09b&width=144&height=89"},
                    new WTCSSchool() {SchoolName="North Central Technical College", url="http://www.ntc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=7866d9de-b2b0-46aa-9de6-e9e7a7540aff&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Northeast Technical College", url="http://www.nwtc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=245be44a-b4bb-451b-a10c-cf8e3fe4d3fa&width=144&height=89"},
                    new WTCSSchool() {SchoolName="SouthWest Tech", url="http://www.swtc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=2b7bfe20-bc0b-47ba-94e7-e6f4cd6ba093&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Waukesha College", url="http://www.wctc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=c9a2acb9-8644-41d1-9fd4-c4a82b54ad06&width=144&height=89"},
                    new WTCSSchool() {SchoolName="Western Technical College", url="http://www.westerntc.edu/", ImageURL="http://www.wtcsystem.edu/CMSPages/GetFile.aspx?guid=54c1966a-b70a-41ed-9335-c49e45623c6e&width=144&height=89"}
                };
        }
    }
}
