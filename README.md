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

## Notes
- To Publish on Github Pages, your repo visibility *must be set to public* then go to:<br>
**Repo Settings** > **Pages** and set **Source** to: `Deploy from a branch` and **Branch** to `gh-pages` or whatever branch name used in [Publish Github Page 🚀](/.github/workflows/deploy-to-github-web.yml) and click `save` <BR>
- Page will be published under: [https://`Repo-Owner`.github.io/`Repo-Name`](https://muammar-yacoob.github.io/Unity-GitActions)


## Tips
- To reduce execution time, in the `main.yml` comment the check unity license section after your first deployment.
- Apart from `deploy-to-github-web.yml` all workflows can be executed individually
- Use the below code snippet to triger workflows on a specific branch or any additional workflows you may add to your project

```yml
on:
  workflow_dispatch: #allows manual execution
  workflow_call: #allows calls from other workflows such as `main.yml`
  push:
    branches:
    - main #Triggers only when pushed into `main`
```
