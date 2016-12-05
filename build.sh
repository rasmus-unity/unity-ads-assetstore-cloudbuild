rm -f Builds/Android.apk
/Applications/Unity\ 5.5.0f3/Unity.app/Contents/MacOS/Unity -projectPath $(pwd) -executeMethod AutoBuilder.PerformAndroidBuild -batchmode -quit

rc=$?; if [[ $rc != 0 ]]; then
    echo "Unity build failed. Please check ~/Library/Logs/Unity/Editor.log"
    exit $rc
fi
