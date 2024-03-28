using Composite.Components;

var computerSciences = new Department("Computer Science");
computerSciences.Add(new Course("C# Programming"));
computerSciences.Add(new Course("Algorithms"));
computerSciences.Add(new Course("Operating Systems"));

var businessCourses = new Department("Business Studies");
businessCourses.Add(new Course("Accounting"));
businessCourses.Add(new Course("Marketing"));
businessCourses.Add(new Course("Economics"));

var enginnering = new Faculty("Engineering");
enginnering.Add(computerSciences);

var business = new Faculty("Business");
business.Add(businessCourses);

enginnering.Display();
business.Display();