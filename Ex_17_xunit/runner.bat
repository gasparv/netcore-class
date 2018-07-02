@echo off
set testProj=%1
set runProj=%2
set argRQ=2
set defaultErr=0
set argC=0
for %%x in (%*) do Set /A argC+=1
rem echo %argC%

if %argC% LSS %argRQ% ( echo Please specify arguments arg1: test_projectFolder arg2:run_projectFolder 
GOTO :EOF
) ELSE ( 
    dotnet test %testProj%
)
IF %ERRORLEVEL% NEQ 0 ( echo TESTS DID NOT PASS! Fix the errors or take a brake :P
        GOTO :EOF 
        ) ELSE (
            dotnet run --project %runProj%
        )
