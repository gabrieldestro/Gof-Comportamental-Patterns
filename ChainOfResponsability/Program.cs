// build chain of responsability 

using ChainOfResponsability.Handlers;

var pm = new ProjectManagerApprover();
var bm = new BranchManagerApprover();
var rh = new RhApprover();

pm.NextApprover(bm);
bm.NextApprover(rh);

pm.ApproveVacation("Gabriel", 5);
pm.ApproveVacation("John", 15);
pm.ApproveVacation("Mary", 30);
pm.ApproveVacation("Josh", 40);