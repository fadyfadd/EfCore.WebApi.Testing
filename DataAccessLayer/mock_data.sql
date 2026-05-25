INSERT INTO application_users ("UserName" , "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount") 
VALUES ('ziad.achkar@yahoo.com',  'ZIAD.ACHKAR@YAHOO.COM', 'ziad.achkar@yahoo.com', 'ZIAD.ACHKAR@YAHOO.COM', true, 'AQAAAAIAAYagAAAAEI0R7GshnId2TuxD1y6K4H114SREz9pT4L8H1Y8Y5p5P/gU7fRkWjM2N5gXvV3bZcw==', 'A1B2C3D4-E5F6-7A8B-9C0D-1E2F3A4B5C6D', 'F6E5D4C3-B2A1-0F9E-8D7C-6B5A4M3L2K1J', '555-0999', true, false, NULL, true, 0);

INSERT INTO students ("first_name" , "last_name" , "enrolled_at" , "user_id") values ('ziad' , 'achkar' , current_timestamp , 1);

Insert Into courses_categories ("name") values ('Software Engineering');

Insert Into courses ("title" , "course_category_id") values ('ASP.NET Core Web API' , 1);
Insert Into courses ("title" , "course_category_id") values ('Java Fundamentals' , 1);
Insert Into courses ("title" , "course_category_id") values ('Python for Data Science' , 1);
Insert Into courses ("title" , "course_category_id") values ('C# Introduction', 1);
Insert Into courses ("title" , "course_category_id") values ('JavaScript Basics', 1);
Insert Into courses ("title" , "course_category_id") values ('Database Design', 1);
Insert Into courses ("title" , "course_category_id") values ('Cloud Computing', 1);
Insert Into courses ("title" , "course_category_id") values ('DevOps Essentials', 1);
Insert Into courses ("title" , "course_category_id") values ('Data Structures Fundamentals', 1);
Insert Into courses ("title" , "course_category_id") values ('Algorithms Basics', 1);
Insert Into courses ("title" , "course_category_id") values ('React for Beginners', 1);