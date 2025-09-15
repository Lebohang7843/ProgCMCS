using System;

namespace ProgCMCS.Models
{
    public class Approval
    {
        public int ApprovalID { get; set; }
        public int ClaimID { get; set; }
        public int ManagerID { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string Decision { get; set; }  // Approved / Rejected
        public string Comments { get; set; }
    }
}
