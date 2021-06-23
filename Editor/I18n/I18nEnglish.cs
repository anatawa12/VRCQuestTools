﻿namespace KRT.VRCQuestTools
{
    class I18nEnglish : I18nBase
    {
        internal override string CancelLabel => "Cancel";

        // Convert Avatar for Quest
        internal override string OverwriteWarningDialogButtonCancel => "Cancel";
        internal override string OverwriteWarningDialogButtonOK => "OK";
        internal override string OverwriteWarningDialogButtonUseAltDir(string altDir)=> $"Use \"{altDir}\"";
        internal override string OverwriteWarningDialogMessage(string artifactsDir)=> $"\"{artifactsDir}\" already exists. Do you want to overwrite?";
        internal override string OverwriteWarningDialogTitle => "VRCQuestTools Warning";
        internal override string AvatarLabel => "Avatar";
        internal override string GenerateQuestTexturesLabel => "Generate Textures for Quest";
        internal override string QuestTexturesDescription => "By generating new textures which applying material's color or emission, get closer to PC version of the avatar";
        internal override string VerifiedShadersLabel => "Verified Shaders";
        internal override string SaveToLabel => "Folder to Save";
        internal override string SelectButtonLabel => "Select";
        internal override string ConvertButtonLabel => "Convert";
        internal override string UpdateTexturesLabel => "Update Only Quest Textures";
        internal override string ConvertingMaterialsDialogMessage => "Converting materials...";
        internal override string GeneratingTexturesDialogMessage => "Generating textures...";
        internal override string MaterialExceptionDialogMessage => "An error occured when converting materials. Aborted.";
        internal override string AnimationClipExceptionDialogMessage => "An error occured when converting Animation Clips. Aborted.";
        internal override string AnimatorControllerExceptionDialogMessage => "An error occured when converting Animator Controllers. Aborted.";
        internal override string WarningForPerformance => "In many cases, the converted avatar's performance rank will be \"Very Poor\" for Quest. Quest users need to use \"Show Avatar\" due to Performance Options limitation.";
        internal override string WarningForAppearance => "Texture's transparency doesn't make any effects, so this will be an issue for facial expression. In this case, please take steps by yourself (for example, by editing animation clips or deleting problematic meshes).\n\n" +
            "You should check converted avatar's appearance on PC by uploading with another Blueprint ID or using Avatars 3.0 local testing.";
        internal override string WarningForUnverifiedShaders => "Following materials are using unverified shaders. Textures might not properly be generated.";
        internal override string AlertForComponents => "Following unsupported components will be removed. Check avatar features after conversion.";
        internal override string TexturesSizeLimitLabel => "Textures Size Limit";
        internal override string CompletedDialogTitle => "VRCQuestTools";
        internal override string CompletedDialogMessage(string originalName) => $"{originalName} has been converted for Quest.\nTest your avatar such as facial expression then upload it for Android platform by using same Blueprint ID as PC version.";

        // Remove Missing Components
        internal override string NoMissingComponentsMessage(string objectName) => $"There are no \"missing\" components in {objectName}.";
        internal override string MissingRemoverConfirmationMessage(string objectName) => $"Remove \"missing\" components from {objectName}.";
        internal override string UnpackPrefabMessage => "This also executes \"Unpack Prefab\" operation.";

        // BlendShapes Copy
        internal override string SourceMeshLabel => "Source Mesh";
        internal override string TargetMeshLabel => "Target Mesh";
        internal override string CopyButtonLabel => "Copy BlendShape Weights";
        internal override string SwitchButtonLabel => "Switch Source/Target";

        // Remove Unsupported Components
        internal override string NoUnsupportedComponentsMessage(string objectName) => $"There are no unsupported components in {objectName}.";
        internal override string UnsupportedRemoverConfirmationMessage(string objectName) => $"Remove following unsupported components from {objectName}.";

        // Metallic Smoothness
        internal override string TextureLabel => "Texture";
        internal override string InvertLabel => "Invert";
        internal override string SaveFileDialogTitle(string thing) => $"Save {thing}";
        internal override string SaveFileDialogMessage => "Please enter a file name to save the texture to";
        internal override string GenerateButtonLabel => "Generate Metallic Smoothness";

        // Unity Settings
        internal override string CacheServerModeLabel => "Cache Server Mode";
        internal override string CacheServerHelp => "By enabling the local cache server, you can save time for such as texture compression from the next. In default preferences, the server takes 10 GB from C drive at maximum.";
        internal override string CacheServerButtonLabel => "Enable Local Cache Server";
        internal override string TextureCompressionLabel => "Android Texture Compression";
        internal override string TextureCompressionHelp => "ASTC improves Quest texture quality in exchange for long compression time";
        internal override string TextureCompressionButtonLabel => "Set texture compression to ASTC";
        internal override string ApplyAllButtonLabel => "Apply All Settings";
        internal override string ShowOnStartupLabel => "Show on startup";
        internal override string AllAppliedHelp => "OK, all recommended settings are applied.";

        // Check for Update
        internal override string CheckLater => "Check later";
        internal override string GetUpdate => "Get update";
        internal override string NewVersionIsAvailable(string latestVersion) => $"VRCQuestTools {latestVersion} is available.";
        internal override string ThereIsNoUpdate => "There is no update.";
    }
}