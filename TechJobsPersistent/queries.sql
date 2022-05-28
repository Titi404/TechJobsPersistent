--Part 1
--datatype for job.employers (int, string, string)
--datatype for job.jobs (int, string, FK)
--datatype for job.jobskills (FK, and, FK??? )
-- a foreign key constraint fails (`job`.`jobskills`, CONSTRAINT `FK_JobSkills_Jobs_JobId` FOREIGN KEY (`JobId`) REFERENCES `jobs` (`Id`) ON DELETE CASCADE)	0.000 sec
--datatype for job.skills (int, string, string)

--Part 2

--Part 3

SELECT * FROM skills ORDER BY Name ASC;

Select *
FROM skills
LEFT JOIN Jobskills on skills.id = jobskills.skillid
WHERE JobSkills.JobId IS NOT NULL
ORDER BY Name ASC;