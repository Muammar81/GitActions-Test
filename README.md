# Git Actions for Unity
*Automate Unity Builds with Ease*

![Promo Image](Promo/bender.png)

## Setup
1. Download [latest release](/releases) and copy `.github` to your project root.
2. Run [Acquire activation file 🔑](/.github/workflows/acuire-unity-activation-file.yml), download and unzip the artifact to get `.alf`.
3. Visit [Unity License Portal](https://license.unity3d.com/manual) and upload `.alf` to obtain `.ulf`.
4. In repo settings, navigate to **Secrets > Actions**, create a secret named `UNITY_LICENSE`.
5. Paste `.ulf` content into `UNITY_LICENSE` secret.
6. Trigger [Build Project 🏗️](/.github/workflows/main.yml) or push to `main` to run the workflow.

> Note:
    For Github Pages, set repo to public. Navigate to **Repo Settings > Pages**, set **Source** to `Deploy from a branch` and **Branch** to `gh-pages`.  
   Page will be published to: [https://`Repo-Owner`.github.io/`Repo-Name`](https://muammar-yacoob.github.io/Unity-GitActions)

## Tips
- Comment out license check in `main.yml` after first deploy to save time.
- All workflows except `deploy-to-github-web.yml` can run independently.
- To trigger specific workflows, use:
```yml
on:
  workflow_dispatch:
  workflow_call:
  push:
    branches:
    - main
```

## UML Diagrams Generation
The project also includes an automated workflow for generating UML diagrams. 
### Usage
Modifying `.puml` files in `docs/diagrams` triggers UML generation. PNGs will have the same names as `.puml` files.

Embed UML in Markdown example
```markdown
![StageSystem Class Diagram](./docs/diagrams/StageSystem.png)
```
![StageSystem Class Diagram](./docs/diagrams/StageSystem.png)





