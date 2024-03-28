using Factory.Abstracts;
using Factory.Concrete;

Logistics logistics;

logistics = new RoadLogistics();
logistics.PlanDelivery();

logistics = new SeaLogistics();
logistics.PlanDelivery();