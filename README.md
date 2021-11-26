# ACME INC - 19002561 POE Task 2

### Generating Database from Backup File
***

1. In the zipped project folder, copy the AcmeIncDb.bak file into your Backup folder in:

    **Program Files> Microsoft SQL Server> MSSQL11.MSSQLSERVER> MSSQL> Backup**

2. Open Microsoft SQL Server and connect your database engine.
3. Right click on 'Databases' in the Object Explorer and select 'Restore Files and Filegroups'.
4. The following wizard will pop up.

    ![Step1](https://am3pap007files.storage.live.com/y4mXWZ79UA6CeB7JSd4WDRTidJ5_AS5x23XXf1GJroTagXs77Atnxe9PMF-1Aet5p48hQsGhrFoRE6zblWyYrSA0K8aSdv5Dic9kjekfSuCrw5N99_68RfNC4201M7eGOu4bv6y1SO0O_RVLyh8ik_I0QUXlkII_GK5ANvxIdbEVSWhbIWNIEZck5VjMysNnA4f?width=300&height=350&cropmode=none)

    Type in 'AcmeIncDb' under Destination for the 'to database' field.

    Click on the elipse highlighted in the image (next to the from device input field).

5. In the new window,  Click on Add and navigate to the Backup folder where you copied the AcmeIncDb.bak file. Select Okay.
    ![Step2](https://am3pap007files.storage.live.com/y4mNmZPvMBOSYsstZrgxEPuVIIQBFNDkVGLJIn66ts_gzFlLhlATLbuHPXXRUiiaTYLPSXIU5sMcrSMoFhRQPLJpcBq2F_DZGucwydpQ5XdeC0pADDnK3t8jVeB1I_enBrqyeDSLvmhYpbqT2VRN2tYJI8Y8OZh9Bfy-j5iykvalbuCaxQc8pDdIC5tHNU8Lz0t?width=300&height=350&cropmode=none)

   
6. Finally, on the Restore Files and Filegroups screen, select the new file and click Okay.

    ![Step3](https://am3pap007files.storage.live.com/y4mCVV9AqC-AE9e3XSswvq0wX-BSGOZDEQ9kWgJXduoZY-18hn4JqsTHGpBvBRZtJQfglA3c_zOV9DAOQcOVKJddALvAjwoRkY3U0_2atSnJmnIB5OdhDyUsCrdjy04i20fg6rsc-kUfCnflLFucqPQeCvDglw6C-6sjkxCPAJtFRZgeMtDFhuyhsFr57yuMOg5?width=300&height=350&cropmode=none)

    Refresh the Database tab in the Object Explorer. The database should appear.


---
---
### Creating and Adding the Connection String
***
1. Extract the files from the zipped file named 'AcmeIncWeb.zip'. 
2. Open Visual Studio and select the project.
3. In the Server Explore, select 'Connect to database'.

   ![Step4](https://am3pap007files.storage.live.com/y4mUfaUDgxp2p9kwPukXUZ5yZxblc4xBD4qoOld7CpGrcyvLF86RKAgmO3gOhXBGh_CagbHJ8W4cKTFm2BdyrZeRZooAD44_iao8W5xCDOiceMmRxidGebIyw2WAFWUF2uCntjI6IUapBSnw5lln9D02T7D_P13ro4ul3SxbcMiWSDZnH3SLK2bIXQgNYkxoH-y?width=400&height=100&cropmode=none)

4. Enter your server name in the field provided and select the database name under 'Connect to a database'.

   ![Step5](https://am3pap007files.storage.live.com/y4mPptSGZY8kJ5PeQ9oo6dA6-2mR-7YTeKMKC2dGo9fQeAd0yIrP-0bt3ybuMUACWsvA6Gofw51XfZMcm-fzomFi9WEK9ZpeSBNSALO0wG01rkvndBTPTo2xoV6CsM6KqDzud9yGrg7b6hdrPI9TvQ0GpYCrdRrn7tsS3wg4RLyWvdnZLMHKDV-M8Qca5IhFV1Z?width=300&height=400&cropmode=none)

5. Right click on the new data conection in the Server Explorer that was created. Select Properties.
6. In the Properties window, copy the connection string.

   ![Step6](https://am3pap007files.storage.live.com/y4mSLyBdGGqxQaP3xb4rPoC6QJZ06H-ykDNWmEaq1VSacM-TDx0uv2scSx3RrfDIJAPpcfIOQW7xXI-jPfNpNpCtYHlZiSNXJXmOelrNGdO5V3B3DomxmuUn15vvFUefXMCc_p3Ujs0xN3YMG4nEmBNpcIbC3y8nakvzxTFSVMhGeHZ1OgNwm7EIqvUKtWElM_F?width=400&height=100&cropmode=none)


7. Navigate to the project's appsettings.json file and replace the value in the inverted commas next to 'AcmeIncDatabase'with the connection string string that you copied.

    ![Step7](https://am3pap007files.storage.live.com/y4mgQ850Mf0dbGnS2DJxMaW8mKZuxU9LS2i9Lbb1pdrf7HnR3VfUgRH0PQv0YuHfpzoVkBsDnR58TJX2jskv9FKXtL9zReEVfZI87cfUAsOl3LOoicyh8_QD5fQ-UhFGD5Xol4ECLejmJB2XiZyJXCxFo9SEg4TnVBL1N4bqn8choIf-bdaWFnSyoPXMXoeut8-?width=500&height=100&cropmode=none)

8. You are now rready to run the application.

---
---
### Running the Application
***

1. In the ribbon bar, click on the green play button. The application should open up in your default browser. 


---
---
### User Roles
***

There is an option from 3 Roles that a user can be assigned to: Customer, Admin and General. The functionalities for each of these roles are:

1. Customer
    * View and search for products
    * Create and account
    * Login
    * Add an item to cart (once logged in)
    * Successfully check out an item and view previous transactions

2. General
    * All the functionality of a customer 
    * View products sold per category over time

3. Admin
     * All the functinal of a General employee
     * Create new admin and general employees



For testing purposes, the following details can be used to login:


1. Customer: 
     * Email: greg@email.com
     * Password: Testing123!

2. General:
     * Email: steve@acmeemail.com
     * Password: Testing123!

3. Admin: 
      * Email: henry@acmeemail.com
      * Password: Testing123!


