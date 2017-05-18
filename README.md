# SpargelSpiel
Our Unity based game for the HoloLens

So that we all can work together follow the steps below or see here: http://kbroman.org/github_tutorial/pages/fork.html

fork this repository to your own account and switch to the forked one

now in your new "own" forked reposotory click on the green "clone or download" button and download the zip file
1. open git bash
2. in git bash: switch to the directory you have chosen for the downloaded and hopefully now unzipped project file
3. in git bash: git init
4. git remote add origin https://github.com/YOURREPOSOTORYNAMEHERE/Spotidoodle.git
5. git remote add NameOfRepo https://github.com/OxanaDoroshkevich/SpargelSpiel.git
6. check your repository status with: git remote -v
this should allow you now to push to your own master and pull from the master master ;)

if you want to commit some changes, follow the following instruction:

1. git status
2. git add . (for all files that were changed) OR git add filename (for specific file)
3. git commit -m "SOME MESSAGE HERE"
4. git push origin master
I would recommend to do the pull requests to merge the local code to the master master branch. so that everything is alwas save from merging error!

Good to know. If you have some problems with git and you can't pull or push or even checkout the master again or something and you're just fucking stuck...

git fetch --all
git reset --hard origin/master

to get the version of your accounts master branch status.



## Developing, Developers in this Project
Selina Magnin, Vincent Weiss, Oxana Doroshkevich, Marco Himmelstein, Frederick Wurfer



### Tools
Unity
VisualStuddio
