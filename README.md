# Git Actions
*Automate Unity Builds*

![kill all humans](Promo/bender.png)

## Setup
1. Download the [latest release](/releases) and Copy the [.github](/.github) directory into your project's root folder.
2. Run the [Acquire activation file 🔑](/.github/workflows/acuire-unity-activation-file.yml) file, download the artifact from the bottom of the page and unzip the .alf file.
3. Go to https://license.unity3d.com/manual while logged into the same email you used for your Unity license and upload the .alf file from step 2, this should give you a .ulf file to be used in step 5.
4. Go to your repo's settings > Secrets > Actions> and create a [new repository secret] named: UNITY_LICENSE
5. Edit the UNITY_LICENSE secret and paste the entire contents of the .ulf file from step 3 and save.
6. Run the [Build Project 🏗️](/.github/workflows/main.yml) or simply push commits to the main branch to execute the main workflow. 


## Tips
- To reduce execution time, in the `main.yml` comment the check unity license section after your first deployment.
- Apart from `deploy-to-github-web.yml` all workflows can be executed individually
- In order to Deploy to Github Pages, first, make sure repo visibility is set to public from: Repo Settings > Pages: change branch to `gh-pages` used in `deploy-to-github-web.yml`
- Use the below to triger workflows on a specific branch

```yml
on:
  workflow_dispatch: #allows manual execution
  workflow_call: #allows calls from other workflows such as `main.yml`
  push:
    branches:
    - main #Triggers only when pushed into `main`
```
