
## This is working progress

# Application Scheduler

Application Scheduler is a simple C# based application to start and stop other application based on time and monitor 
data usage. If data usage exceed the limit, Application Scheduler will stop the running application.

Example usage is in Indonesia, there is one 3G data provider who give bonus data in the middle 
of the night with limited data usage. Bonus valid between 2.00 AM - 2.59 AM
with limit 300 MB. It's such a waste to not using it and of course you are sleeping at night.
Which make such bonus useless.

With this application, one can start downloader application and just left this Scheduler running. 
It will start downloader at specified time and stop it when end time or data limit exceeded.

### How to use

### Limitation
