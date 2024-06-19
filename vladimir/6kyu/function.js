function isValidIP(str) {
    const parts = str.split('.');
    
    if (parts.length !== 4) {
        return false;
    }

    for (let part of parts) {
        if (!/^\d+$/.test(part) || (part.length > 1 && part[0] === '0')) {
        return false;
    }

    const num = Number(part);
    if (num < 0 || num > 255) {
        return false;
    }
    }

    return true;
}