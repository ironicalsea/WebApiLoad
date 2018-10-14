@echo off
IF "%~1"=="" GOTO :usage
@echo on
git merge --no-commit --squash %1
git reset HEAD
@echo off
goto :eof
:usage
@echo Usage: gitMergeSquash.bat branch_to_merge_and_squash_from
exit /B 1