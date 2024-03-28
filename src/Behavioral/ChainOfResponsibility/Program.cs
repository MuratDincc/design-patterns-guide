using ChainOfResponsibility.Domain;
using ChainOfResponsibility.Enums;
using ChainOfResponsibility.Handlers;

var complaintHandler = new ComplaintEmailHandler();
var infoEmailHandler = new InfoEmailHandler();
var technicalEmailHandler = new TechnicalEmailHandler();

complaintHandler.SetNextHandler(infoEmailHandler);
infoEmailHandler.SetNextHandler(technicalEmailHandler);

var complaintEmail = new Email { Type = EmailType.Complaint };
var infoEmail = new Email { Type = EmailType.Information };
var technicalSupportEmail = new Email { Type = EmailType.TechnicalSupport };

complaintHandler.HandleRequest(complaintEmail);
complaintHandler.HandleRequest(infoEmail);
complaintHandler.HandleRequest(technicalSupportEmail);