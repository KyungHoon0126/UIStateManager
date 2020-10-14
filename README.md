# UIStateManagerLibrary
UserControl 관리를 위한 Library

## HOW TO USE

- UIStateManagerLibrary 적용 방법 1단계

<img src="https://user-images.githubusercontent.com/48943501/95931359-e8e5d800-0e03-11eb-9471-923415cde143.JPG" width="80%"></img>

GitHub에서 zip 파일을 다운받은 후 압축 파일을 풀어준다.

<img src="https://user-images.githubusercontent.com/48943501/95931045-1b430580-0e03-11eb-8927-3030a1d88028.png" width="80%"></img>

솔루션 우클릭 후, Add -> Existing Project를 누르고 다운 받은 UIStateManagerLibrary 폴더에서 UIStateManagerLibrary.csproj를 추가해준다.



- UIStateManagerLibraryLibrary 적용 방법 2단계

<img src="https://user-images.githubusercontent.com/48943501/95931090-2f870280-0e03-11eb-86e8-450e5e8f1fa0.png" width="80%"></img>

프로젝트 하단의 References를 우클릭 한 후 Add Reference를 눌러준다.

<img src="https://user-images.githubusercontent.com/48943501/95931517-4e39c900-0e04-11eb-9c0b-33e42801635a.png" width="80%"></img>

프로젝트 탭에서 추가한 Library를 체크하고 OK 버튼을 눌러준다.



- UIStateManagerLibrary 적용 방법 3단계

<img src="https://user-images.githubusercontent.com/48943501/95931126-49c0e080-0e03-11eb-8d43-9b3d965e23fd.png" width="80%"></img>

(필수 X) 여러 컨트롤에서 다루어야 하기에 App.xaml.cs에서 UIStateManager를 미리 선언해둔다.



- UIStateManagerLibrary 적용 방법 4단계

<img src="https://user-images.githubusercontent.com/48943501/95931149-58a79300-0e03-11eb-8ca7-c90e0b419b02.png" width="80%"></img>

사용하고자 하는 UserControl들을 만들어 준다,



- UIStateManagerLibrary 적용 방법 5단계

<img src="https://user-images.githubusercontent.com/48943501/95931193-6fe68080-0e03-11eb-8ed8-51a496cbee15.png" width="80%"></img>

UserControl.xaml.cs에서 "ExampleControl : UserControl" 상속을 "ExampleControl : CustomControl"로 바꾸어 준다.



- UIStateManagerLibrary 적용 방법 6단계

<img src="https://user-images.githubusercontent.com/48943501/95931204-783ebb80-0e03-11eb-8ac8-9a3e6b4401a6.png" width="80%"></img>

만든 UserControl의 XAML 상단 첫 태그를 UserControl이 아니라 base:CustomControl로 바꾸어 준다.



- UIStateManagerLibrary 적용 방법 7단계

<img src="https://user-images.githubusercontent.com/48943501/95931767-ffd8fa00-0e04-11eb-9494-f0d638ae396d.png" width="80%"></img>

6단계까지 완료했다면, MainWindow.xaml로 가서 만들어둔 UserControl들을 모두 불러 준다.



- UIStateManagerLibrary 적용 방법 8단계

<img src="https://user-images.githubusercontent.com/48943501/95931217-7ecd3300-0e03-11eb-95f2-37f468d6b940.png" width="80%"></img>

그리고 MainWindow.xaml.cs에서 초기 설정을 진행해 준다.



★ ZIP 압축 해제시 UIStateManagerLibrary 폴더와 Example 폴더가 존재하는데, UIStateManagerLibrary는 사용하는 Library이고 Example을 이해를 돕기 위한 사용 예제 프로젝트 임.  ★
