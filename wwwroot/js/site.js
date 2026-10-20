/**
 * FocusFlow - Core Site Interactions & Utilities
 */

document.addEventListener('DOMContentLoaded', function () {
    // 1. Mobile Menu Toggle
    const mobileMenuBtn = document.getElementById('mobileMenuBtn');
    const appSidebar = document.getElementById('appSidebar');
    const sidebarBackdrop = document.getElementById('sidebarBackdrop');

    if (mobileMenuBtn && appSidebar && sidebarBackdrop) {
        mobileMenuBtn.addEventListener('click', function () {
            appSidebar.classList.toggle('sidebar-open');
            sidebarBackdrop.classList.toggle('active');
        });

        sidebarBackdrop.addEventListener('click', function () {
            appSidebar.classList.remove('sidebar-open');
            sidebarBackdrop.classList.remove('active');
        });

        // Close sidebar when clicking any navigation link on mobile
        document.querySelectorAll('.sidebar-nav-link').forEach(link => {
            link.addEventListener('click', function () {
                if (window.innerWidth <= 820) {
                    appSidebar.classList.remove('sidebar-open');
                    sidebarBackdrop.classList.remove('active');
                }
            });
        });
    }

    // 2. Top Header Blur on Scroll
    const topHeader = document.getElementById('topHeader');
    window.addEventListener('scroll', function () {
        if (!topHeader) return;
        if (window.scrollY > 20) {
            topHeader.classList.add('header-scrolled');
        } else {
            topHeader.classList.remove('header-scrolled');
        }
    });

    // 3. Global Search Keyboard Shortcut (Cmd+F / Ctrl+K)
    const searchInput = document.getElementById('globalSearchInput');
    window.addEventListener('keydown', function (e) {
        if ((e.metaKey || e.ctrlKey) && (e.key === 'f' || e.key === 'k')) {
            e.preventDefault();
            if (searchInput) {
                searchInput.focus();
                searchInput.select();
            }
        }
    });

    // 4. Set current date formatted
    const dateDisplay = document.getElementById('currentDateDisplay');
    if (dateDisplay) {
        const today = new Date();
        const options = { weekday: 'long', month: 'short', day: 'numeric' };
        dateDisplay.textContent = today.toLocaleDateString('en-US', options);
    }
});
