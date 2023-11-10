## Aws Lambda

        * Aws lambda is a serverless computing platform and it is used for executing the background tasks , not for hosting an application
      
       The Advantages of Lambda are:
       
        * No maintainance 
        * Pay as you go
        * High Availability
        * Built in security
        * Easy Integration 
        
        * Eg:
               * S3 Bucket: Execute a Lambda function when a new file is uploaded to an S3 bucket. Useful for processing and analyzing 
               data,such as image resizing or data transformation.

         * Run time support by Aws lambda are:
         
                * Python 
                * Java
                * Node
                * Dot Net
                * Go
                * Ruby
                
        * Lambda functions:
               * Code
               * Test
               * Monitor
               * Configuration
               * Aliases
               * Versions
               
               * Lambda is works on .json format.
               
               * Imp : Before creating the lambda trigger check the right Iam Permissions assigned or not.
               
       * Aws Layers:
              * A function can include a common or shared resource called Layers.
                     Eg :
                     Aws layers are where u store the packages or files.
              
       * Api Gateway Integration using Lambda:
              * Api gateway integration using lambda allows used to create a rest api that invoke your lambda functions.
                 This is powerful and flexible way to build scalable and powerful applications.

       * Lambda Snapshot:
              * Cold Start
              ** Aws lambda has three stages to start:(Cold Start it has init and have latency): 
                     1.init (it loads the runtime).
                     2.invoke (It trigger the function after initalization).
                     3.shutdown.
                     
              Note: 
                     * Latency will be more for java projects compare to other programming languages.
                     * To avoid the cold start problem you can use the snapstart for avoiding the latency .
                     * Snapstart is only available for Java Language and available for the versions above java-11 and beyond.
                     ** Advantage of using snapstart is:
                      * You can avoid the pricing as snapstart is free and price low compare to cold start.
                            
                     
                     
              
        
        

    
