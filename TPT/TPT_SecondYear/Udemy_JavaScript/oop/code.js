const solution = (str) => {
    let backwards = "";
    for (i = str.length - 1; i >= 0; i--) {
        backwards += str[i];
    }
    return backwards;
}
solution("world");