## .NET Core 3.0.0-rc1-19456-20 (CoreCLR 4.700.19.45506, CoreFX 4.700.19.45604), 64bit RyuJIT
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParameters()
                   return TestParametersSub(Date.ToString());
                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov     rcx,7FF7DCA4C3D0h
       mov     edx,2
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rcx,20F5EFD7320h
       mov     rcx,qword ptr [rcx]
       add     rcx,8
       call    System.DateTime.ToString()
       mov     qword ptr [rbp-8],rax
       mov     rdx,qword ptr [rbp-8]
       mov     rcx,qword ptr [rbp+10h]
       call    Test.LazyParameters.Benchmark_LazyParameters.TestParametersSub(System.String)
; Total bytes of code 59
```
```assembly
; System.DateTime.ToString()
       mov     rcx,qword ptr [rcx]
       xor     edx,edx
       xor     r8d,r8d
       call    qword ptr [System_Private_CoreLib+0x11460
; Total bytes of code 14
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersSub(System.String)
                    if (Condition)
                    ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+10h]
       call    Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
       test    eax,eax
       je      M02_L00
                       return date;
                       ^^^^^^^^^^^^
       mov     rax,qword ptr [rbp+18h]
       lea     rsp,[rbp]
       pop     rbp
       ret
                       return string.Empty;
                       ^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov     rax,20F5EFD3060h
       mov     rax,qword ptr [rax]
; Total bytes of code 36
```
```assembly
; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider)
       call    qword ptr [System_Private_CoreLib+0x1a70
       mov     r9,qword ptr [rax+240h]
       mov     r9,qword ptr [r9+8]
       mov     rdx,rsi
       mov     r8,rdi
       mov     rcx,rbx
       call    qword ptr [System_Private_CoreLib+0x11468
; Total bytes of code 32
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
               public bool Condition { get; set; }
                                       ^^^^
       mov     rax,qword ptr [rbp+10h]
       movzx   eax,byte ptr [rax+8]
; Total bytes of code 8
```

## .NET Core 3.0.0-rc1-19456-20 (CoreCLR 4.700.19.45506, CoreFX 4.700.19.45604), 64bit RyuJIT
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersLazyLambda()
                   return TestParametersLambdaSub(() => Date.ToString());
                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov     rcx,7FF7DCA1C3D0h
       mov     edx,3
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rcx,19A38197330h
       mov     rcx,qword ptr [rcx]
       mov     qword ptr [rbp-18h],rcx
       mov     rcx,qword ptr [rbp+10h]
       mov     qword ptr [rbp-20h],rcx
       mov     rcx,qword ptr [rbp-18h]
       mov     qword ptr [rbp-28h],rcx
       cmp     qword ptr [rbp-18h],0
       jne     M00_L00
       mov     rcx,7FF7DCAADB10h
       call    coreclr!coreclr_shutdown_2+0xd9d0
       mov     qword ptr [rbp-30h],rax
       mov     rcx,7FF7DCA1C3D0h
       mov     edx,3
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rdx,19A38197328h
       mov     rdx,qword ptr [rdx]
       mov     qword ptr [rbp-38h],rdx
       mov     rdx,qword ptr [rbp-38h]
       mov     r8,7FF7DCAD76D0h
       mov     rcx,qword ptr [rbp-30h]
       call    System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov     rcx,7FF7DCA1C3D0h
       mov     edx,3
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rcx,19A38197330h
       mov     rdx,qword ptr [rbp-30h]
       call    coreclr!coreclr_shutdown_2+0xcae0
       mov     rcx,qword ptr [rbp-30h]
       mov     qword ptr [rbp-28h],rcx
M00_L00:
       mov     rcx,qword ptr [rbp-20h]
       mov     rdx,qword ptr [rbp-28h]
       call    Test.LazyParameters.Benchmark_LazyParameters.TestParametersLambdaSub(System.Func`1<System.String>)
; Total bytes of code 203
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       test    rdx,rdx
       je      System_Private_CoreLib+0x3a4ac6
       lea     rcx,[rsi+8]
       call    qword ptr [System_Private_CoreLib+0x1028
       mov     qword ptr [rsi+18h],rdi
       add     rsp,28h
       pop     rsi
       pop     rdi
       ret
       mov     rcx,rsi
       call    qword ptr [System_Private_CoreLib+0xf268
       int     3
       push    rdi
       push    rsi
       push    rbx
       sub     rsp,30h
       mov     rsi,rcx
       mov     rdi,rdx
       mov     rbx,r8
       mov     rdx,qword ptr [rdi+8]
       lea     rcx,[rsi+20h]
; Total bytes of code 60
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersLambdaSub(System.Func`1<System.String>)
                   if (Condition)
                   ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+10h]
       call    Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
       test    eax,eax
       je      M02_L00
                       return date();
                       ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+18h]
       mov     qword ptr [rbp-8],rcx
       mov     rcx,qword ptr [rbp-8]
       mov     rcx,qword ptr [rcx+8]
       mov     rax,qword ptr [rbp-8]
       call    qword ptr [rax+18h]
       nop
       lea     rsp,[rbp]
       pop     rbp
       ret
                       return string.Empty;
                       ^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov     rax,19A38193060h
       mov     rax,qword ptr [rax]
; Total bytes of code 56
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
               public bool Condition { get; set; }
                                       ^^^^
       mov     rax,qword ptr [rbp+10h]
       movzx   eax,byte ptr [rax+8]
; Total bytes of code 8
```
**Method got most probably inlined**
Test.LazyParameters.Benchmark_LazyParameters+<>c.<TestParametersLazyLambda>b__7_0()
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.0.0-rc1-19456-20 (CoreCLR 4.700.19.45506, CoreFX 4.700.19.45604), 64bit RyuJIT
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersLazyLocalFunc()
                   return TestParametersLazyLocalFuncSub(LocalFunc);
                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov     rcx,7FF7DCADDB10h
       call    coreclr!coreclr_shutdown_2+0xd9d0
       mov     qword ptr [rbp-8],rax
       mov     rcx,7FF7DCA4C3D0h
       mov     edx,3
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rdx,2A76A387328h
       mov     rdx,qword ptr [rdx]
       mov     qword ptr [rbp-10h],rdx
       mov     rdx,qword ptr [rbp-10h]
       mov     r8,7FF7DCB076D8h
       mov     rcx,qword ptr [rbp-8]
       call    System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov     rcx,qword ptr [rbp+10h]
       mov     rdx,qword ptr [rbp-8]
       call    Test.LazyParameters.Benchmark_LazyParameters.TestParametersLazyLocalFuncSub(System.Func`1<System.String>)
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       test    rdx,rdx
       je      System_Private_CoreLib+0x3a4ac6
       lea     rcx,[rsi+8]
       call    qword ptr [System_Private_CoreLib+0x1028
       mov     qword ptr [rsi+18h],rdi
       add     rsp,28h
       pop     rsi
       pop     rdi
       ret
       mov     rcx,rsi
       call    qword ptr [System_Private_CoreLib+0xf268
       int     3
       push    rdi
       push    rsi
       push    rbx
       sub     rsp,30h
       mov     rsi,rcx
       mov     rdi,rdx
       mov     rbx,r8
       mov     rdx,qword ptr [rdi+8]
       lea     rcx,[rsi+20h]
; Total bytes of code 60
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersLazyLocalFuncSub(System.Func`1<System.String>)
                   if (Condition)
                   ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+10h]
       call    Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
       test    eax,eax
       je      M02_L00
                       return date();
                       ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+18h]
       mov     qword ptr [rbp-8],rcx
       mov     rcx,qword ptr [rbp-8]
       mov     rcx,qword ptr [rcx+8]
       mov     rax,qword ptr [rbp-8]
       call    qword ptr [rax+18h]
       nop
       lea     rsp,[rbp]
       pop     rbp
       ret
                       return string.Empty;
                       ^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov     rax,2A76A383060h
       mov     rax,qword ptr [rax]
; Total bytes of code 56
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
               public bool Condition { get; set; }
                                       ^^^^
       mov     rax,qword ptr [rbp+10h]
       movzx   eax,byte ptr [rax+8]
; Total bytes of code 8
```
**Method got most probably inlined**
Test.LazyParameters.Benchmark_LazyParameters+<>c.<TestParametersLazyLocalFunc>g__LocalFunc|9_0()
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.0.0-rc1-19456-20 (CoreCLR 4.700.19.45506, CoreFX 4.700.19.45604), 64bit RyuJIT
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParameters()
                   return TestParametersSub(Date.ToString());
                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov     rcx,7FF7DCA4C3D0h
       mov     edx,2
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rcx,15B28987320h
       mov     rcx,qword ptr [rcx]
       add     rcx,8
       call    System.DateTime.ToString()
       mov     qword ptr [rbp-8],rax
       mov     rdx,qword ptr [rbp-8]
       mov     rcx,qword ptr [rbp+10h]
       call    Test.LazyParameters.Benchmark_LazyParameters.TestParametersSub(System.String)
; Total bytes of code 59
```
```assembly
; System.DateTime.ToString()
       mov     rcx,qword ptr [rcx]
       xor     edx,edx
       xor     r8d,r8d
       call    qword ptr [System_Private_CoreLib+0x11460
; Total bytes of code 14
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersSub(System.String)
                    if (Condition)
                    ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+10h]
       call    Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
       test    eax,eax
       je      M02_L00
                       return date;
                       ^^^^^^^^^^^^
       mov     rax,qword ptr [rbp+18h]
       lea     rsp,[rbp]
       pop     rbp
       ret
                       return string.Empty;
                       ^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov     rax,15B28983060h
       mov     rax,qword ptr [rax]
; Total bytes of code 36
```
```assembly
; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider)
       call    qword ptr [System_Private_CoreLib+0x1a70
       mov     r9,qword ptr [rax+240h]
       mov     r9,qword ptr [r9+8]
       mov     rdx,rsi
       mov     r8,rdi
       mov     rcx,rbx
       call    qword ptr [System_Private_CoreLib+0x11468
; Total bytes of code 32
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
               public bool Condition { get; set; }
                                       ^^^^
       mov     rax,qword ptr [rbp+10h]
       movzx   eax,byte ptr [rax+8]
; Total bytes of code 8
```

## .NET Core 3.0.0-rc1-19456-20 (CoreCLR 4.700.19.45506, CoreFX 4.700.19.45604), 64bit RyuJIT
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersLazyLambda()
                   return TestParametersLambdaSub(() => Date.ToString());
                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov     rcx,7FF7DCA2C3D0h
       mov     edx,3
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rcx,20814357330h
       mov     rcx,qword ptr [rcx]
       mov     qword ptr [rbp-18h],rcx
       mov     rcx,qword ptr [rbp+10h]
       mov     qword ptr [rbp-20h],rcx
       mov     rcx,qword ptr [rbp-18h]
       mov     qword ptr [rbp-28h],rcx
       cmp     qword ptr [rbp-18h],0
       jne     M00_L00
       mov     rcx,7FF7DCABDB10h
       call    coreclr!coreclr_shutdown_2+0xd9d0
       mov     qword ptr [rbp-30h],rax
       mov     rcx,7FF7DCA2C3D0h
       mov     edx,3
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rdx,20814357328h
       mov     rdx,qword ptr [rdx]
       mov     qword ptr [rbp-38h],rdx
       mov     rdx,qword ptr [rbp-38h]
       mov     r8,7FF7DCAE80D8h
       mov     rcx,qword ptr [rbp-30h]
       call    System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov     rcx,7FF7DCA2C3D0h
       mov     edx,3
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rcx,20814357330h
       mov     rdx,qword ptr [rbp-30h]
       call    coreclr!coreclr_shutdown_2+0xcae0
       mov     rcx,qword ptr [rbp-30h]
       mov     qword ptr [rbp-28h],rcx
M00_L00:
       mov     rcx,qword ptr [rbp-20h]
       mov     rdx,qword ptr [rbp-28h]
       call    Test.LazyParameters.Benchmark_LazyParameters.TestParametersLambdaSub(System.Func`1<System.String>)
; Total bytes of code 203
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       test    rdx,rdx
       je      System_Private_CoreLib+0x3a4ac6
       lea     rcx,[rsi+8]
       call    qword ptr [System_Private_CoreLib+0x1028
       mov     qword ptr [rsi+18h],rdi
       add     rsp,28h
       pop     rsi
       pop     rdi
       ret
       mov     rcx,rsi
       call    qword ptr [System_Private_CoreLib+0xf268
       int     3
       push    rdi
       push    rsi
       push    rbx
       sub     rsp,30h
       mov     rsi,rcx
       mov     rdi,rdx
       mov     rbx,r8
       mov     rdx,qword ptr [rdi+8]
       lea     rcx,[rsi+20h]
; Total bytes of code 60
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersLambdaSub(System.Func`1<System.String>)
                   if (Condition)
                   ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+10h]
       call    Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
       test    eax,eax
       je      M02_L00
                       return date();
                       ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+18h]
       mov     qword ptr [rbp-8],rcx
       mov     rcx,qword ptr [rbp-8]
       mov     rcx,qword ptr [rcx+8]
       mov     rax,qword ptr [rbp-8]
       call    qword ptr [rax+18h]
       nop
       lea     rsp,[rbp]
       pop     rbp
       ret
                       return string.Empty;
                       ^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov     rax,20814353060h
       mov     rax,qword ptr [rax]
; Total bytes of code 56
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters+<>c.<TestParametersLazyLambda>b__7_0()
                   return TestParametersLambdaSub(() => Date.ToString());
                                                        ^^^^^^^^^^^^^^^
       mov     rcx,7FF7DCA2C3D0h
       mov     edx,2
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rcx,20814357320h
       mov     rcx,qword ptr [rcx]
       add     rcx,8
       call    System.DateTime.ToString()
; Total bytes of code 42
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
               public bool Condition { get; set; }
                                       ^^^^
       mov     rax,qword ptr [rbp+10h]
       movzx   eax,byte ptr [rax+8]
; Total bytes of code 8
```
```assembly
; System.DateTime.ToString()
       mov     rcx,qword ptr [rcx]
       xor     edx,edx
       xor     r8d,r8d
       call    qword ptr [System_Private_CoreLib+0x11460
; Total bytes of code 14
```
**Method got most probably inlined**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.0.0-rc1-19456-20 (CoreCLR 4.700.19.45506, CoreFX 4.700.19.45604), 64bit RyuJIT
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersLazyLocalFunc()
                   return TestParametersLazyLocalFuncSub(LocalFunc);
                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov     rcx,7FF7DCAADB10h
       call    coreclr!coreclr_shutdown_2+0xd9d0
       mov     qword ptr [rbp-8],rax
       mov     rcx,7FF7DCA1C3D0h
       mov     edx,3
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rdx,21C11577328h
       mov     rdx,qword ptr [rdx]
       mov     qword ptr [rbp-10h],rdx
       mov     rdx,qword ptr [rbp-10h]
       mov     r8,7FF7DCAD80E0h
       mov     rcx,qword ptr [rbp-8]
       call    System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov     rcx,qword ptr [rbp+10h]
       mov     rdx,qword ptr [rbp-8]
       call    Test.LazyParameters.Benchmark_LazyParameters.TestParametersLazyLocalFuncSub(System.Func`1<System.String>)
; Total bytes of code 92
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       test    rdx,rdx
       je      System_Private_CoreLib+0x3a4ac6
       lea     rcx,[rsi+8]
       call    qword ptr [System_Private_CoreLib+0x1028
       mov     qword ptr [rsi+18h],rdi
       add     rsp,28h
       pop     rsi
       pop     rdi
       ret
       mov     rcx,rsi
       call    qword ptr [System_Private_CoreLib+0xf268
       int     3
       push    rdi
       push    rsi
       push    rbx
       sub     rsp,30h
       mov     rsi,rcx
       mov     rdi,rdx
       mov     rbx,r8
       mov     rdx,qword ptr [rdi+8]
       lea     rcx,[rsi+20h]
; Total bytes of code 60
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.TestParametersLazyLocalFuncSub(System.Func`1<System.String>)
                   if (Condition)
                   ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+10h]
       call    Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
       test    eax,eax
       je      M02_L00
                       return date();
                       ^^^^^^^^^^^^^^
       mov     rcx,qword ptr [rbp+18h]
       mov     qword ptr [rbp-8],rcx
       mov     rcx,qword ptr [rbp-8]
       mov     rcx,qword ptr [rcx+8]
       mov     rax,qword ptr [rbp-8]
       call    qword ptr [rax+18h]
       nop
       lea     rsp,[rbp]
       pop     rbp
       ret
                       return string.Empty;
                       ^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov     rax,21C11573060h
       mov     rax,qword ptr [rax]
; Total bytes of code 56
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters+<>c.<TestParametersLazyLocalFunc>g__LocalFunc|9_0()
                       return Date.ToString();
                       ^^^^^^^^^^^^^^^^^^^^^^^
       mov     rcx,7FF7DCA1C3D0h
       mov     edx,2
       call    coreclr!coreclr_shutdown_2+0xddd0
       mov     rcx,21C11577320h
       mov     rcx,qword ptr [rcx]
       add     rcx,8
       call    System.DateTime.ToString()
; Total bytes of code 42
```
```assembly
; Test.LazyParameters.Benchmark_LazyParameters.get_Condition()
               public bool Condition { get; set; }
                                       ^^^^
       mov     rax,qword ptr [rbp+10h]
       movzx   eax,byte ptr [rax+8]
; Total bytes of code 8
```
```assembly
; System.DateTime.ToString()
       mov     rcx,qword ptr [rcx]
       xor     edx,edx
       xor     r8d,r8d
       call    qword ptr [System_Private_CoreLib+0x11460
; Total bytes of code 14
```
**Method got most probably inlined**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

