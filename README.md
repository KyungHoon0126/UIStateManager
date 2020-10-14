# UI State Manager Library
> 대구 소프트웨어 고등학교 친구들이 Kiosk 개발 시, UserControl을 통한 화면 관리를 할 때 편리하게 관리할 수 있도록 도와주는 라이브러리 입니다.

## 사용전 꼭 읽어 주세요!!
> ZIP 파일 다운로드 후, 압축 해제시 UIStateManagerLibrary 폴더와 Example 폴더가 존재하는데, UIStateManagerLibrary 폴더는 프로젝트에 추가하여 사용하는 Library이고, Example 폴더는 이해를 돕기 위해 만든 사용 예제 프로젝트 입니다. 

## UI State Manager Library 설정 방법

- UIStateManagerLibrary 사용 방법 1단계

<img src="https://user-images.githubusercontent.com/48943501/95931359-e8e5d800-0e03-11eb-9471-923415cde143.JPG" width="80%"></img>

1. GitHub에서 ZIP 파일을 다운받은 후 압축 파일을 풀어준다.

<img src="https://user-images.githubusercontent.com/48943501/95931045-1b430580-0e03-11eb-8927-3030a1d88028.png" width="80%"></img>

1-1. Solution(솔루션) 우 클릭 후, Add -> Existing Project를 누르고 다운 받은 UIStateManagerLibrary 폴더에서 UIStateManagerLibrary.csproj를 찾아서 추가해 줍니다.



- UIStateManagerLibrary 사용 방법 2단계

<img src="https://user-images.githubusercontent.com/48943501/95931090-2f870280-0e03-11eb-86e8-450e5e8f1fa0.png" width="80%"></img>

2. Project(프로젝트) 하단의 References를 우 클릭 한 후 Add Reference를 눌러줍니다.

<img src="https://user-images.githubusercontent.com/48943501/95931517-4e39c900-0e04-11eb-9c0b-33e42801635a.png" width="80%"></img>

2-1. 프로젝트 탭에서 방금 추가한 Library를 체크하고 OK 버튼을 눌러줍니다.



- UI State Manager Library 사용 방법 3단계

<img src="https://user-images.githubusercontent.com/48943501/95931126-49c0e080-0e03-11eb-8d43-9b3d965e23fd.png" width="80%"></img>

3. 여러 컨트롤에서 다루어야 하기에 App.xaml.cs에서 UIStateManager를 미리 선언해둔다. 
※이 위치에 필수적으로 선언해두어야 하는 것은 아니지만, 다른 곳에서 사용하고자 할 경우 UIStateManager 클래스의 객체를 만들어 사용해야 합니다. ※



- UI State Manager Library 사용 방법 4단계

<img src="https://user-images.githubusercontent.com/48943501/95931149-58a79300-0e03-11eb-8ca7-c90e0b419b02.png" width="80%"></img>

4. 사용하고자 하는 UserControl들을 만들어 줍니다.



- UI State Manager Library 사용 방법 5단계

<img src="https://user-images.githubusercontent.com/48943501/95931193-6fe68080-0e03-11eb-8ed8-51a496cbee15.png" width="80%"></img>

5. ex)ExampleControl.xaml.cs에서 "ExampleControl : UserControl" 상속을 "ExampleControl : CustomControlModel"로 바꾸어 줍니다.



- UI State Manager Library 사용 방법 6단계

<img src="https://user-images.githubusercontent.com/48943501/95931204-783ebb80-0e03-11eb-8ac8-9a3e6b4401a6.png" width="80%"></img>

6. 만든 UserControl의 XAML 상단 첫 태그를 "UserControl"이 아니라 "base:CustomControl"로 바꾸어 줍니다.



- UI State Manager Library 사용 방법 7단계

<img src="https://user-images.githubusercontent.com/48943501/95931767-ffd8fa00-0e04-11eb-9494-f0d638ae396d.png" width="80%"></img>

7. 6단계까지 완료했다면, MainWindow.xaml로 가서 만들어둔 UserControl들을 모두 불러 줍니다.



- UI State Manager Library 사용 방법 8단계

<img src="https://user-images.githubusercontent.com/48943501/95931217-7ecd3300-0e03-11eb-95f2-37f468d6b940.png" width="80%"></img>

8. MainWindow.xaml.cs에서 초기 설정을 진행해 준다.


★☆이렇게 해주면 사용하기 위한 모든 설정은 끝이 납니다. 화면 전환을 위해서는 SwitchCustomControl() 메서드를 이용하면 되고, 사용법은 주석을 다 달아 놓았습니다. 이해가 어려우면 Example 예제를 참고해 주세요. 혹시나 수정, 버그 사항이 있으면 알려주시면 바로 수정하도록 하겠습니다.☆★
