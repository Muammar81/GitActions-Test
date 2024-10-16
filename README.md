# Git Actions for Unity
*Automate Unity Builds with Ease*

![Promo Image](Promo/bender.png)

**Description:**  
Git Actions for Unity automates your Unity build process with GitHub Actions, simplifying setup and enhancing developer productivity.

## Quick Setup
1. Download [latest release](/releases) and copy `.github` to your project root.
2. Run [Acquire activation file 🔑](/.github/workflows/acuire-unity-activation-file.yml), download and unzip the artifact to get `.alf`.
3. Visit [Unity License Portal](https://license.unity3d.com/manual) and upload `.alf` to obtain `.ulf`.
4. In repo settings, navigate to **Secrets > Actions**, create a secret named `UNITY_LICENSE`.
5. Paste `.ulf` content into `UNITY_LICENSE` secret.
6. Trigger [Build Project 🏗️](/.github/workflows/main.yml) or push to `main` to run the workflow.

> Note:
    For Github Pages, set repo to public. Navigate to **Repo Settings > Pages**, set **Source** to `Deploy from a branch` and **Branch** to `gh-pages`.  
   Page will be published to: [https://`Repo-Owner`.github.io/`Repo-Name`](https://muammar-yacoob.github.io/Unity-GitActions)


## Notifications Setup
#### 1. Create a Webhook
  - Discord: Server Settings > Integrations > Webhooks > New Webhook > Select the appropriate Channel
  - MS Teams: [Channel] > ... > Connectors > Incoming Webhook > Configure
- Slack: [Workspace] > Administration > Manage apps > Custom Integrations > Incoming WebHooks

#### 2. GitHub Settings
- In GitHub Repo Settings: Secrets > Actions > New repository secret
- Name: DISCORD_WEBHOOK, MS_TEAMS_WEBHOOK, or SLACK_WEBHOOK
- Value: Paste the respective webhook URL


## UML Diagrams Generation
The project also includes an automated workflow for generating UML diagrams. 
### Usage
Modifying `.puml` files in `docs/diagrams` triggers UML generation. PNGs will have the same names as `.puml` files.

Embed UML in Markdown example
```markdown
![StageSystem Class Diagram](./docs/diagrams/StageSystem.png)
```
![StageSystem Class Diagram](./docs/diagrams/StageSystem.png)


## Acknowledgments
The project is using the following services:
- [PlantUML project](http://plantuml.com): Licensed under [GPL](http://www.gnu.org/copyleft/gpl.html).
- [PlantUmlClassDiagramGenerator](https://github.com/pierre3/PlantUmlClassDiagramGenerator) by pierre3: Licensed under [MIT](https://github.com/pierre3/PlantUmlClassDiagramGenerator/blob/master/LICENSE).
- [PlantUML URL generator project](https://gitlab.com/iternity/plantuml.cs) by iTernity GmbH: Licensed under [MIT](https://gitlab.com/iternity/plantuml.cs/blob/master/LICENSE).
