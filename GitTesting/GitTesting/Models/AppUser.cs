using System;

namespace GitTesting.Models
{
    public class AppUser
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string SID { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime LastRequest { get; set; }
        //public UserType UserType { get; set; }
        //public BrowseBy OncologyBrowseBy { get; set; }
        public bool IsReviewer { get; set; } = false;


        //[JsonIgnore]
        //[Ignore]
        //public bool IsPharmacologyUser
        //{
        //    get
        //    {
        //        if (UserType == UserType.Pharmacology)
        //            return true;

        //        return false;
        //    }
        //}

        //[JsonIgnore]
        //[Ignore]
        //public bool IsOncologyUser
        //{
        //    get
        //    {
        //        if (UserType == UserType.Oncology)
        //            return true;

        //        return false;
        //    }
        //}

        //[JsonIgnore]
        //[Ignore]
        //public bool IsAuthIDTokenValid
        //{
        //    get
        //    {
        //        return true;

        //        //TODO:Uncomment this code after authentication is implemented
        //        //if (SID == null)
        //        //    return false;

        //        //return (ValidFrom.ToLocalTime() <= DateTime.Now && ValidTo.ToLocalTime() >= DateTime.Now);
        //    }
        //}
    }
}
