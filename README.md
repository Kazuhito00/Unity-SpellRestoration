# Unity-SpellRestoration
Unityで「ふっかつのじゅもん」的なことをするクラスです。
<img src="https://user-images.githubusercontent.com/37477845/112488121-9fd97d00-8dc0-11eb-9dc9-854edc8d2cbe.gif" width="60%">

# Demo
動作確認用ページは以下。<br>
[https://kazuhito00.github.io/Unity-SpellRestoration/WebGL-Build](https://kazuhito00.github.io/Unity-SpellRestoration/WebGL-Build)

# Requirement (Unity)
* Unity 2021.1.0b6 or later

# Memo
使用しやすさを優先して以下のような変換処理にしています。<br>
構造体の変数名を長くすると生成される文字列も長くなります。短くしたい場合は変数名を短くしてください。<br>
<img src="https://user-images.githubusercontent.com/37477845/112489045-6bb28c00-8dc1-11eb-8653-8f569d77e804.png" width="25%">

# Example
使用例は以下の通りです。<br>
ToSpellRestoration()で「ふっかつのじゅもん」を生成し、<br>
FromSpellRestoration()で「ふっかつのじゅもん」から構造体に戻します。<br>
```
[System.Serializable]
public class SaveData
{
    public string a;
    public string b;
    public string c;
}
```

```
saveData = new SaveData();
sr = new SpellRestoration();

var spellRestoration = sr.ToSpellRestoration(saveData);
saveData = sr.FromSpellRestoration<SaveData>(spellRestoration);
```

実際に使用している例は[InputManager.cs](https://github.com/Kazuhito00/Unity-SpellRestoration/blob/main/SpellRestoration/Assets/Scripts/InputManager.cs)を参照ください。

# ToDo
 - [ ] [WebGLでの日本語入力・コピー＆ペーストについて](https://helpdesk.unity3d.co.jp/hc/ja/articles/220207047-WebGL%E3%81%A7%E3%81%AE%E6%97%A5%E6%9C%AC%E8%AA%9E%E5%85%A5%E5%8A%9B-%E3%82%B3%E3%83%94%E3%83%BC-%E3%83%9A%E3%83%BC%E3%82%B9%E3%83%88%E3%81%AB%E3%81%A4%E3%81%84%E3%81%A6)

# Author
高橋かずひと(https://twitter.com/KzhtTkhs)

# License 
Unity-SpellRestoration is under [Apache v2 License](LICENSE).
